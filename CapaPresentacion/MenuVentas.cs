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
    public partial class MenuVentas : Form
    {
        private Usuario _user;
        public MenuVentas(Usuario user = null)
        {
            _user = user;
            InitializeComponent();
        }

        private void MenuVentas_Load(object sender, EventArgs e)
        {
            coDocumento.Items.Add(new OpcionCombo() { Texto = "Boleta", Valor = "Boleta" });
            coDocumento.Items.Add(new OpcionCombo() { Texto = "Factura", Valor = "Factura" });
            coDocumento.DisplayMember = "Texto";
            coDocumento.ValueMember = "Valor";
            coDocumento.SelectedIndex = 0;

            texFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            texIdProducto.Text = "0";

        }

        private void BtnBuscarDoc_Click(object sender, EventArgs e)
        {
            using (var buscar = new BuscadorCliente())
            {
                var resultado = buscar.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    texDocumentoCliente.Text = buscar._cliente.Documento.ToString();
                    texNombreCliente.Text = buscar._cliente.NombreCompleto.ToString();
                    texCodigoProd.Select();
                }
                else
                    texDocumentoCliente.Select();
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
                    texPrecio.Text = buscar._producto.PrecioVenta.ToString("0.00");
                    texStock.Text = buscar._producto.Stock.ToString();
                    numCantidad.Select();
                }
                else
                    texCodigoProd.Select();
            }
        }

        private void texCodigoProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto producto = new CN_Producto().Listar().Where(p => p.Codigo == texCodigoProd.Text && p.Estado).FirstOrDefault();

                if (producto != null)
                {
                    texCodigoProd.BackColor = Color.Honeydew;
                    texIdProducto.Text = producto.IdProducto.ToString();
                    texNombreProd.Text = producto.Nombre.ToString();
                    texPrecio.Text = producto.PrecioVenta.ToString("0.00");
                    texStock.Text = producto.Stock.ToString();
                    numCantidad.Select();
                }
                else
                {
                    texCodigoProd.BackColor = Color.MistyRose;
                    texIdProducto.Text = "0";
                    texNombreProd.Clear();
                    texPrecio.Clear();
                    texStock.Clear();
                    numCantidad.Value = 1;
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool existe = false;

            if (Convert.ToInt32(texIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texCodigoProd.Select();
                return;
            }

            if (!decimal.TryParse(texPrecio.Text, out precio))
            {
                MessageBox.Show("Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToInt32(texStock.Text) < Convert.ToInt32(numCantidad.Value.ToString())) 
            {
                MessageBox.Show("La cantidad es mayor al stock disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in DgvData.Rows)
            {
                if (row.Cells["IdProducto"].Value != null && row.Cells["IdProducto"].Value.ToString() == texIdProducto.Text)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                bool respuesta = new CN_Venta().RestarStock(Convert.ToInt32(texIdProducto.Text), Convert.ToInt32(numCantidad.Value.ToString()));

                DgvData.Rows.Add
                    (
                        new object[]
                        {
                            texIdProducto.Text,
                            texNombreProd.Text,
                            precio.ToString("0.00"),
                            numCantidad.Value.ToString(),
                            (numCantidad.Value * precio).ToString("0.00")
                        }
                    );
                CalcularTotal();
                LimpiarProducto();
                texCodigoProd.Select();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            if (DgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvData.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null)
                        total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }

            }
            texTotalPagar.Text = total.ToString("0.00");
        }

        private void LimpiarProducto()
        {
            texIdProducto.Text = "0";
            texCodigoProd.Clear();
            texCodigoProd.BackColor = Color.White;
            texNombreProd.Clear();
            texPrecio.Clear();
            texStock.Clear();
            numCantidad.Value = 1;
        }

        private void DgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
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
                    bool respuesta = new CN_Venta().SumarStock(Convert.ToInt32(DgvData.Rows[i].Cells["IdProducto"].Value.ToString()), 
                                                               Convert.ToInt32(DgvData.Rows[i].Cells["Cantidad"].Value.ToString()));
                    if (respuesta)
                    {
                        DgvData.Rows.RemoveAt(i);
                        CalcularTotal();
                        LimpiarProducto();
                    }                  
                }
            }
        }

        private void texPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (texPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void texPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (texPago.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void CalcularCambio()
        {
            if(texTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No hay producto en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal paga = 0;
            decimal total = Convert.ToDecimal(texTotalPagar.Text);

            if (texPago.Text.Trim() == "")
                texPago.Text = "0";

            if(decimal.TryParse(texPago.Text, out paga))
            {
                if (paga == total)
                    texCambio.Text = "0.00";
                else if(paga < total)
                    MessageBox.Show("Pago Insuficiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    decimal cambio = paga - total;
                    texCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void texPago_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }

        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            if (texDocumentoCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texDocumentoCliente.Select();
                return;
            }

            if (texNombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texDocumentoCliente.Select();
                return;
            }

            if (texPago.Text == "")
            {
                MessageBox.Show("Debe pagar primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texPago.Select();
                return;
            }

            if (DgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                texCodigoProd.Select();
                return;
            }

            DataTable detalleVenta = new DataTable();

            detalleVenta.Columns.Add("IdProducto", typeof(int));
            detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in DgvData.Rows)
            {
                detalleVenta.Rows.Add(new object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }

            int idCorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);
            CalcularCambio();

            Venta venta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _user.IdUsuario },
                TipoDocumento = ((OpcionCombo)coDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = texDocumentoCliente.Text,
                NombreCliente = texNombreCliente.Text,
                MontoPago = Convert.ToDecimal(texPago.Text),
                MontoCambio = Convert.ToDecimal(texCambio.Text),
                MontoTotal = Convert.ToDecimal(texTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool resultado = new CN_Venta().Registrar(venta, detalleVenta, out mensaje);

            if (resultado)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                texDocumentoCliente.Clear();
                texNombreCliente.Clear();
                LimpiarProducto();
                texTotalPagar.Text = "0";
                texPago.Text = "";
                texCambio.Text = "";
                DgvData.Rows.Clear();
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
