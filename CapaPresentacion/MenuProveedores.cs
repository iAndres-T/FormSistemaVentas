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

namespace CapaPresentacion
{
    public partial class MenuProveedores : Form
    {
        public MenuProveedores()
        {
            InitializeComponent();
        }

        private void MenuProveedores_Load(object sender, EventArgs e)
        {
            coEstado.Items.Add(new OpcionCombo() { Texto = "Activo", Valor = 1 });
            coEstado.Items.Add(new OpcionCombo() { Texto = "No Activo", Valor = 0 });
            coEstado.DisplayMember = "Texto";
            coEstado.ValueMember = "Valor";
            coEstado.SelectedIndex = 0;


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

            List<Proveedor> lista = new CN_Proveedor().Listar();

            foreach (Proveedor item in lista)
            {
                DgvData.Rows.Add(new object[] {
                    "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        public void Limpiar()
        {
            texIndice.Text = "-1";
            texId.Text = "0";
            texDocumento.Clear();
            texRazonSocial.Clear();
            texCorreo.Clear();
            texTelefono.Clear();
            coEstado.SelectedIndex = 0;

            texDocumento.Select();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Proveedor prove = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(texId.Text),
                Documento = texDocumento.Text,
                RazonSocial = texRazonSocial.Text,
                Correo = texCorreo.Text,
                Telefono = texTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)coEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (prove.IdProveedor == 0)
            {
                int idProveedorGenerado = new CN_Proveedor().Registrar(prove, out Mensaje);

                if (idProveedorGenerado != 0)
                {
                    DgvData.Rows.Add(new object[]
                    {
                        "",
                        idProveedorGenerado,
                        texDocumento.Text,
                        texRazonSocial.Text,
                        texCorreo.Text,
                        texTelefono.Text,
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
                bool respuesta = new CN_Proveedor().Editar(prove, out Mensaje);

                if (respuesta)
                {
                    DataGridViewRow row = DgvData.Rows[Convert.ToInt32(texIndice.Text)];
                    row.Cells["Id"].Value = texId.Text;
                    row.Cells["Documento"].Value = texDocumento.Text;
                    row.Cells["RazonSocial"].Value = texRazonSocial.Text;
                    row.Cells["Correo"].Value = texCorreo.Text;
                    row.Cells["Telefono"].Value = texTelefono.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)coEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)coEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                    MessageBox.Show(Mensaje);
            }
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
                    texDocumento.Text = DgvData.Rows[i].Cells["Documento"].Value.ToString();
                    texRazonSocial.Text = DgvData.Rows[i].Cells["RazonSocial"].Value.ToString();
                    texCorreo.Text = DgvData.Rows[i].Cells["Correo"].Value.ToString();
                    texTelefono.Text = DgvData.Rows[i].Cells["Telefono"].Value.ToString();

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
                if (MessageBox.Show("¿Desea eliminar el Proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Proveedor prove = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(texId.Text)
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(prove, out Mensaje);

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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
