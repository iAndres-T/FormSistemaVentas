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
    public partial class MenuProducto : Form
    {
        public MenuProducto()
        {
            InitializeComponent();
        }

        private void MenuProducto_Load(object sender, EventArgs e)
        {
            coEstado.Items.Add(new OpcionCombo() { Texto = "Activo", Valor = 1 });
            coEstado.Items.Add(new OpcionCombo() { Texto = "No Activo", Valor = 0 });
            coEstado.DisplayMember = "Texto";
            coEstado.ValueMember = "Valor";
            coEstado.SelectedIndex = 0;

            List<Categoria> listCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listCategoria)
            {
                coCategoria.Items.Add(new OpcionCombo() { Texto = item.Descripcion, Valor = item.IdCategoria });
            }

            coCategoria.DisplayMember = "Texto";
            coCategoria.ValueMember = "Valor";
            coCategoria.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in DgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSelect")
                {
                    coBuscar.Items.Add(new OpcionCombo() { Texto = columna.HeaderText, Valor = columna.Name });
                }
            }

            coBuscar.DisplayMember = "Texto";
            coBuscar.ValueMember = "Valor";
            coBuscar.SelectedIndex = 0;

            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {
                DgvData.Rows.Add(new object[]
                {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }

            coCategoria.DisplayMember = "Texto";
            coCategoria.ValueMember = "Valor";
            coCategoria.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Producto produ = new Producto()
            {
                IdProducto = Convert.ToInt32(texId.Text),
                Codigo = texCodigo.Text,
                Nombre = texNombre.Text,
                Descripcion = texDescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)coCategoria.SelectedItem).Valor), Descripcion = ((OpcionCombo)coCategoria.SelectedItem).Texto },
                Estado = Convert.ToInt32(((OpcionCombo)coEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (produ.IdProducto == 0)
            {
                int idProductoGenerado = new CN_Producto().Registrar(produ, out Mensaje);

                if (idProductoGenerado != 0)
                {
                    DgvData.Rows.Add(new object[]
                    {
                        "",
                        idProductoGenerado,
                        texCodigo.Text,
                        texNombre.Text,
                        texDescripcion.Text,
                        ((OpcionCombo)coCategoria.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)coCategoria.SelectedItem).Texto.ToString(),
                        "0",
                        "0.00",
                        "0.00",
                        ((OpcionCombo)coEstado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)coEstado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                }
                else
                    MessageBox.Show(Mensaje);
            }
            else
            {
                bool respuesta = new CN_Producto().Editar(produ, out Mensaje);

                if (respuesta)
                {
                    DataGridViewRow row = DgvData.Rows[Convert.ToInt32(texIndice.Text)];
                    row.Cells["Id"].Value = texId.Text;
                    row.Cells["Codigo"].Value = texCodigo.Text;
                    row.Cells["Nombre"].Value = texNombre.Text;
                    row.Cells["Descripcion"].Value = texDescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)coCategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)coCategoria.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)coEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)coEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                    MessageBox.Show(Mensaje);
            }
        }

        public void Limpiar()
        {
            texIndice.Text = "-1";
            texId.Text = "0";
            texCodigo.Clear();
            texNombre.Clear();
            texDescripcion.Clear();
            coCategoria.SelectedIndex = 0;
            coEstado.SelectedIndex = 0;

            texCodigo.Select();
        }

        private void DgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Check.Width;
                var h = Properties.Resources.Check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Columns[e.ColumnIndex].Name == "BtnSelect")
            {
                int i = e.RowIndex;

                if (i >= 0)
                {
                    texIndice.Text = i.ToString();
                    texId.Text = DgvData.Rows[i].Cells["Id"].Value.ToString();
                    texCodigo.Text = DgvData.Rows[i].Cells["Codigo"].Value.ToString();
                    texNombre.Text = DgvData.Rows[i].Cells["Nombre"].Value.ToString();
                    texDescripcion.Text = DgvData.Rows[i].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo op in coCategoria.Items)
                    {
                        if (Convert.ToInt32(op.Valor) == Convert.ToInt32(DgvData.Rows[i].Cells["IdCategoria"].Value))
                        {
                            int indiceCo = coCategoria.Items.IndexOf(op);
                            coCategoria.SelectedIndex = indiceCo;
                            break;
                        }
                    }

                    foreach (OpcionCombo op in coEstado.Items)
                    {
                        if (Convert.ToInt32(op.Valor) == Convert.ToInt32(DgvData.Rows[i].Cells["EstadoValor"].Value))
                        {
                            int indiceCo = coEstado.Items.IndexOf(op);
                            coEstado.SelectedIndex = indiceCo;
                            break;
                        }
                    }
                }
            }
        }

        private void BtnDescartar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(texId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Producto produ = new Producto()
                    {
                        IdProducto = Convert.ToInt32(texId.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(produ, out Mensaje);

                    if (respuesta)
                    {
                        DgvData.Rows.RemoveAt(Convert.ToInt32(texIndice.Text));
                        Limpiar();
                    }
                    else
                        MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));

                foreach (DataGridViewRow row in DgvData.Rows)
                    if (row.Visible)
                        dt.Rows.Add
                            (
                                new object[]
                                {
                                    row.Cells[2].Value.ToString(),
                                    row.Cells[3].Value.ToString(),
                                    row.Cells[4].Value.ToString(),
                                    row.Cells[6].Value.ToString(),
                                    row.Cells[7].Value.ToString(),
                                    row.Cells[8].Value.ToString(),
                                    row.Cells[9].Value.ToString(),
                                    row.Cells[11].Value.ToString(),
                                }
                            );

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProductos_{0}xlsx", DateTime.Now.ToString("dd-MM-yyyy-hh-mm-tt"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Informe generado","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
