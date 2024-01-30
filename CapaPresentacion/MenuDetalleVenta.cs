using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuDetalleVenta : Form
    {
        public MenuDetalleVenta()
        {
            InitializeComponent();
        }

        private void MenuDetalleVenta_Load(object sender, EventArgs e)
        {
            texBuscarDocumento.Select();
        }

        private void BtnBuscarDoc_Click(object sender, EventArgs e)
        {
            Venta venta = new CN_Venta().ObtenerVenta(texBuscarDocumento.Text);

            if(venta.IdVenta != 0)
            {
                texNumeroDocumento.Text = venta.NumeroDocumento;

                texFecha.Text = venta.FechaRegistro;
                texTipoDocumento.Text = venta.TipoDocumento;
                texUsuario.Text = venta.oUsuario.NombreCompleto;

                texDocumentoCliente.Text = venta.DocumentoCliente;
                texNombreCliente.Text = venta.NombreCliente;

                DgvData.Rows.Clear();

                foreach(Detalle_Venta dv in venta.oDetalleVenta)
                {
                    DgvData.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal});
                }

                texMontoTotal.Text = venta.MontoTotal.ToString("0.00");
                texMontoPago.Text = venta.MontoPago.ToString("0.00");
                texMontoCambio.Text = venta.MontoCambio.ToString("0.00");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            texBuscarDocumento.Clear();
            texFecha.Clear();
            texTipoDocumento.Clear();
            texUsuario.Clear();
            texDocumentoCliente.Clear();
            texNombreCliente.Clear();
            DgvData.Rows.Clear();
            texMontoTotal.Text = "0";
            texMontoCambio.Text = "0";
            texMontoPago.Text = "0";
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            if (texTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textoHtml = Properties.Resources.PlantillaVenta.ToString();
            Negocio datos = new CN_Negocio().ObtenerDatos();

            textoHtml = textoHtml.Replace("@nombrenegocio", datos.Nombre.ToUpper());
            textoHtml = textoHtml.Replace("@docnegocio", datos.RUC);
            textoHtml = textoHtml.Replace("@direcnegocio", datos.Direccion);

            textoHtml = textoHtml.Replace("@tipodocumento", texTipoDocumento.Text.ToUpper());
            textoHtml = textoHtml.Replace("@numerodocumento", texNumeroDocumento.Text);

            textoHtml = textoHtml.Replace("@doccliente", texDocumentoCliente.Text);
            textoHtml = textoHtml.Replace("@nombrecliente", texNombreCliente.Text);
            textoHtml = textoHtml.Replace("@fecharegistro", texFecha.Text);
            textoHtml = textoHtml.Replace("@usuarioregistro", texUsuario.Text);

            string filas = string.Empty;

            foreach (DataGridViewRow row in DgvData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            textoHtml = textoHtml.Replace("@filas", filas);
            textoHtml = textoHtml.Replace("@montototal", texMontoTotal.Text);
            textoHtml = textoHtml.Replace("@pagocon", texMontoPago.Text);
            textoHtml = textoHtml.Replace("@cambio", texMontoCambio.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Venta_{0}.pdf", texNumeroDocumento.Text);
            saveFile.Filter = "Pdf Files|*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(textoHtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
