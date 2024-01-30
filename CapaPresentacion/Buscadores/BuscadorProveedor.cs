using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Buscadores
{
    public partial class BuscadorProveedor : Form
    {
        public Proveedor _proveedor { get; set; }
        public BuscadorProveedor()
        {
            InitializeComponent();
        }

        private void BuscadorProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DgvData.Columns)
            {
                if (columna.Visible)
                {
                    coBuscar.Items.Add(new OpcionCombo() { Texto = columna.HeaderText, Valor = columna.Name });
                }
            }

            coBuscar.DisplayMember = "Texto";
            coBuscar.ValueMember = "Valor";
            coBuscar.SelectedIndex = 0;

            List<Proveedor> lista = new CN_Proveedor().Listar();

            foreach (Proveedor item in lista)
            {
                DgvData.Rows.Add(new object[] {item.IdProveedor,item.Documento,item.RazonSocial});
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

        private void DgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int colum = e.ColumnIndex;

            if(row >= 0 && colum > 0)
            {
                _proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(DgvData.Rows[row].Cells["Id"].Value.ToString()),
                    Documento = DgvData.Rows[row].Cells["Documento"].Value.ToString(),
                    RazonSocial = DgvData.Rows[row].Cells["RazonSocial"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
