using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
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
    public partial class Inicio : Form
    {
        private Usuario userAct;
        private IconMenuItem menuActivo = null;
        private Form formActivo = null;

        public Inicio(Usuario user = null)
        {
            if(user == null)
                userAct = new Usuario() { NombreCompleto = "ADMIN DEFINIDO", IdUsuario = 1};
            else
                this.userAct = user;

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> _permisos = new CN_Permiso().Listar(userAct.IdUsuario);

            foreach(IconMenuItem icon in menu.Items)
            {
                bool encontrado = _permisos.Any(i => i.NombreMenu == icon.Name);
                if(!encontrado)
                    icon.Visible = false;
            }

            lbdUsuario.Text = userAct.NombreCompleto;
        }

        private void OpenForm(IconMenuItem menu, Form form)
        {
            if (menuActivo != null)
                menuActivo.BackColor = Color.White;

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if(formActivo != null)
                formActivo.Close();

            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(form);
            form.Show();


        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new MenuUsuarios());
        }

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            OpenForm(menuMantenedor, new MenuCategoria());
        }

        private void submenuProducto_Click(object sender, EventArgs e)
        {
            OpenForm(menuMantenedor, new MenuProducto());
        }

        private void subRegistrarVenta_Click(object sender, EventArgs e)
        {
            OpenForm(menuVentas, new MenuVentas(userAct));
        }

        private void subDetalleVenta_Click(object sender, EventArgs e)
        {
            OpenForm(menuVentas, new MenuDetalleVenta());
        }

        private void subRegistrarCompra_Click(object sender, EventArgs e)
        {
            OpenForm(menuCompras, new MenuCompras(userAct));
        }

        private void subDetallaCompra_Click(object sender, EventArgs e)
        {
            OpenForm(menuCompras, new MenuDetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new MenuClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new MenuProveedores());
        }       

        private void submenuNegocio_Click(object sender, EventArgs e)
        {
            OpenForm(menuMantenedor, new MenuNegocio());
        }

        private void submenuResporteCompra_Click(object sender, EventArgs e)
        {
            OpenForm(menuReportes, new MenuReporteCompra());
        }

        private void submenuReporteVenta_Click(object sender, EventArgs e)
        {
            OpenForm(menuReportes, new MenuReporteVenta());
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            MenuAcercaDe menu = new MenuAcercaDe();
            menu.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Salir?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
