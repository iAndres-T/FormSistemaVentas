using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuReporteVenta : Form
    {
        public MenuReporteVenta()
        {
            InitializeComponent();
        }

        private void MenuReporteVenta_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DgvData.Columns)
            {
                coBuscar.Items.Add(new OpcionCombo() { Texto = columna.HeaderText, Valor = columna.Name });
            }

            coBuscar.DisplayMember = "Texto";
            coBuscar.ValueMember = "Valor";
            coBuscar.SelectedIndex = 0;
        }

        private void BtnBuscarProv_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(texFechaInicio.Value.ToString("dd/MM/yyyy"), texFechaFin.Value.ToString("dd/MM/yyyy"));

            DgvData.Rows.Clear();

            foreach (ReporteVenta rc in lista)
            {
                DgvData.Rows.Add(new object[]
                {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoCliente,
                    rc.NombreCliente,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = ((OpcionCombo)coBuscar.SelectedItem).Valor.ToString();

            if (DgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvData.Rows)
                {
                    if (row.Cells[filtro].Value.ToString().Trim().ToUpper().Contains(texBuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void BtnLimpiarBarra_Click(object sender, EventArgs e)
        {
            texBuscar.Clear();

            foreach (DataGridViewRow row in DgvData.Rows)
                row.Visible = true;
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (DgvData.Rows.Count < 1)
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in DgvData.Columns)
                    dt.Columns.Add(columna.HeaderText, typeof(string));

                foreach (DataGridViewRow row in DgvData.Rows)
                    if (row.Visible)
                        dt.Rows.Add
                            (
                                new object[]
                                {
                                    row.Cells[0].Value.ToString(),
                                    row.Cells[1].Value.ToString(),
                                    row.Cells[2].Value.ToString(),
                                    row.Cells[3].Value.ToString(),
                                    row.Cells[4].Value.ToString(),
                                    row.Cells[5].Value.ToString(),
                                    row.Cells[6].Value.ToString(),
                                    row.Cells[7].Value.ToString(),
                                    row.Cells[8].Value.ToString(),
                                    row.Cells[9].Value.ToString(),
                                    row.Cells[10].Value.ToString(),
                                    row.Cells[11].Value.ToString(),
                                    row.Cells[12].Value.ToString()
                                }
                            );

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy-hh-mm-tt"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Informe generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar informe {ex}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
