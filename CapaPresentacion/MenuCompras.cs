using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Buscadores;
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

namespace CapaPresentacion
{
    public partial class MenuCompras : Form
    {
        private Usuario _user;
        public MenuCompras(Usuario user = null)
        {
            _user = user;
            InitializeComponent();
        }

        private void MenuCompras_Load(object sender, EventArgs e)
        {
            coDocumento.Items.Add(new OpcionCombo() { Texto = "Boleta", Valor = "Boleta" });
            coDocumento.Items.Add(new OpcionCombo() { Texto = "Factura", Valor = "Factura" });
            coDocumento.DisplayMember = "Texto";
            coDocumento.ValueMember = "Valor";
            coDocumento.SelectedIndex = 0;

            texFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            texIdProducto.Text = "0";
            texIdProveedor.Text = "0";


        }

        private void BtnBuscarDoc_Click(object sender, EventArgs e)
        {
            using(var buscar = new BuscadorProveedor())
            {
                var resultado = buscar.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    texIdProveedor.Text = buscar._proveedor.IdProveedor.ToString();
                    texDocumentoProv.Text = buscar._proveedor.Documento.ToString();
                    texNombreProv.Text = buscar._proveedor.RazonSocial.ToString();
                }
                else
                    texDocumentoProv.Select();
            }
        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            using (var buscar = new BuscadorProducto())
            {
                var resultado = buscar.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    texIdProducto.Text = buscar._producto.IdProducto.ToString();
                    texCodigoProd.Text = buscar._producto.Codigo.ToString();
                    texCodigoProd.BackColor = Color.Honeydew;
                    texNombreProd.Text = buscar._producto.Nombre.ToString();
                    texPrecioCompra.Select();
                }
                else
                    texCodigoProd.Select();
            }
        }

        private void texCodigoProd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Producto producto = new CN_Producto().Listar().Where(p => p.Codigo == texCodigoProd.Text && p.Estado).FirstOrDefault();

                if(producto != null)
                {
                    texCodigoProd.BackColor = Color.Honeydew;
                    texIdProducto.Text = producto.IdProducto.ToString();
                    texNombreProd.Text = producto.Nombre.ToString();
                    texPrecioCompra.Select();
                }
                else
                {
                    texCodigoProd.BackColor = Color.MistyRose;
                    texIdProducto.Text = "0";
                    texNombreProd.Text = "";
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            decimal compra = 0;
            decimal venta = 0;
            bool existe = false;

            if(Convert.ToInt32(texIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texCodigoProd.Select();
                return;
            }

            if(!decimal.TryParse(texPrecioCompra.Text, out compra))
            {
                MessageBox.Show("Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texPrecioCompra.Select(); 
                return;
            }
            
            if(!decimal.TryParse(texPrecioVenta.Text, out venta))
            {
                MessageBox.Show("Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texPrecioVenta.Select(); 
                return;
            }


            foreach(DataGridViewRow row in DgvData.Rows)
            {
                if (row.Cells["IdProducto"].Value != null && row.Cells["IdProducto"].Value.ToString() == texIdProducto.Text)
                {
                    existe = true;
                    break;
                }
            }

            if(!existe)
            {
                DgvData.Rows.Add
                    (
                        new object[]
                        {
                            texIdProducto.Text,
                            texNombreProd.Text,
                            compra.ToString("0.00"),
                            venta.ToString("0.00"),
                            numCantidad.Value.ToString(),
                            (numCantidad.Value * compra).ToString("0.00")
                        }
                    );
                CalcularTotal();
                LimpiarProducto();
                texCodigoProd.Select();
            }
        }

        private void LimpiarProducto()
        {
            texIdProducto.Text = "0";
            texCodigoProd.Clear();
            texCodigoProd.BackColor = Color.White;
            texNombreProd.Clear();
            texPrecioCompra.Clear();
            texPrecioVenta.Clear();
            numCantidad.Value = 1;
        }

        private void CalcularTotal()
        {
            decimal total = 0; 

            if(DgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvData.Rows)
                {
                    if(row.Cells["SubTotal"].Value != null)
                        total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
                    
            }
            texTotalPagar.Text = total.ToString("0.00");
        }

        private void DgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Trash.Width;
                var h = Properties.Resources.Trash.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Trash, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Columns[e.ColumnIndex].Name == "BtnDelete")
            {
                int i = e.RowIndex;

                if (i >= 0)
                {
                    DgvData.Rows.RemoveAt(i);
                    CalcularTotal();
                }
            }
        }

        private void texPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (texPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                    e.Handled = true;
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                        e.Handled = false;
                    else
                        e.Handled = true;                   
                }
            }
        }

        private void texPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (texPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                    e.Handled = true;
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(texIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texDocumentoProv.Select();
                return;
            }

            if(DgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texDocumentoProv.Select();
                return;
            }

            DataTable detalleCompra = new DataTable();

            detalleCompra.Columns.Add("IdProducto", typeof(int));
            detalleCompra.Columns.Add("PrecioCompra", typeof(decimal));
            detalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            detalleCompra.Columns.Add("Cantidad", typeof(int));
            detalleCompra.Columns.Add("MontoTotal", typeof(decimal));

            foreach(DataGridViewRow row in DgvData.Rows)
            {
                detalleCompra.Rows.Add(new object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Stock"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }

            int idCorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Compra objCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _user.IdUsuario},
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(texIdProveedor.Text)},
                TipoDocumento = ((OpcionCombo)coDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(texTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool resultado = new CN_Compra().Registrar(objCompra, detalleCompra, out mensaje);

            if (resultado)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                texIdProveedor.Text = "0";
                texDocumentoProv.Clear();
                texNombreProv.Clear();
                DgvData.Rows.Clear();
                texTotalPagar.Text = "0";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
