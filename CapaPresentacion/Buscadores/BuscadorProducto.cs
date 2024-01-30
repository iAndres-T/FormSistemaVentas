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
    public partial class BuscadorProducto : Form
    {
        public Producto _producto { get; set; }
        public BuscadorProducto()
        {
            InitializeComponent();
        }

        private void BuscadorProducto_Load(object sender, EventArgs e)
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

            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {
                DgvData.Rows.Add(new object[]
                {
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta
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

        private void DgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int colum = e.ColumnIndex;

            if (row >= 0 && colum > 0)
            {
                _producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(DgvData.Rows[row].Cells["Id"].Value.ToString()),
                    Codigo = DgvData.Rows[row].Cells["Codigo"].Value.ToString(),
                    Nombre = DgvData.Rows[row].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(DgvData.Rows[row].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(DgvData.Rows[row].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(DgvData.Rows[row].Cells["PrecioVenta"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
