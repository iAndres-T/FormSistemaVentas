using CapaEntidad;
using CapaNegocio;
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
    public partial class MenuNegocio : Form
    {
        public MenuNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void MenuNegocio_Load(object sender, EventArgs e)
        {
            bool respuesta = true;
            byte[] byteImage = new CN_Negocio().ObtenerLogo(out respuesta);

            if(respuesta)
                pictureLogo.Image = ByteToImage(byteImage);

            Negocio datos = new CN_Negocio().ObtenerDatos();

            texNegocio.Text = datos.Nombre;
            texRUC.Text = datos.RUC;
            texDireccion.Text = datos.Direccion;
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] imagen = File.ReadAllBytes(fileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(imagen, out mensaje);

                if (respuesta)
                    pictureLogo.Image = ByteToImage(imagen);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Negocio obj = new Negocio()
            {
                Nombre = texNegocio.Text,
                RUC = texRUC.Text,
                Direccion = texDireccion.Text
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios se realizaron con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Los cambios no se realizaron", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
