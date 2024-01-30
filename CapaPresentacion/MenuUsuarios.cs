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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {
            coEstado.Items.Add(new OpcionCombo() { Texto = "Activo", Valor = 1 });
            coEstado.Items.Add(new OpcionCombo() { Texto = "No Activo", Valor = 0 });
            coEstado.DisplayMember = "Texto";
            coEstado.ValueMember = "Valor";
            coEstado.SelectedIndex = 0;

            List<Rol> listRol = new CN_Rol().Listar();

            foreach (Rol item in listRol)
            {
                coRol.Items.Add(new OpcionCombo() { Texto = item.Descripcion, Valor = item.IdRol });
            }

            coRol.DisplayMember = "Texto";
            coRol.ValueMember = "Valor";
            coRol.SelectedIndex = 0;

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

            List<Usuario> listUsers = new CN_Usuario().Listar();

            foreach (Usuario item in listUsers)
            {
                DgvData.Rows.Add(new object[] {"", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }

            coRol.DisplayMember = "Texto";
            coRol.ValueMember = "Valor";
            coRol.SelectedIndex = 0;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Usuario user = new Usuario()
            {
                IdUsuario = Convert.ToInt32(texId.Text),
                Documento = texDocumento.Text,
                NombreCompleto = texNombreCom.Text,
                Correo = texCorreo.Text,
                Clave = texClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)coRol.SelectedItem).Valor), Descripcion = ((OpcionCombo)coRol.SelectedItem).Texto.ToString() },
                Estado = Convert.ToInt32(((OpcionCombo)coEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if(user.IdUsuario == 0)
            {
                int idUsuarioGenerado = new CN_Usuario().Registrar(user, out Mensaje);

                if (idUsuarioGenerado != 0)
                {
                    DgvData.Rows.Add(new object[] {"",idUsuarioGenerado, texDocumento.Text, texNombreCom.Text, texCorreo.Text, texClave.Text,
                    ((OpcionCombo)coRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)coRol.SelectedItem).Texto.ToString(),
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
                bool respuesta = new CN_Usuario().Editar(user, out Mensaje);

                if (respuesta)
                {
                    DataGridViewRow row = DgvData.Rows[Convert.ToInt32(texIndice.Text)];
                    row.Cells["Id"].Value = texId.Text;
                    row.Cells["Documento"].Value = texDocumento.Text;
                    row.Cells["NombreCompleto"].Value = texNombreCom.Text;
                    row.Cells["Correo"].Value = texCorreo.Text;
                    row.Cells["Clave"].Value = texClave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)coRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)coRol.SelectedItem).Texto.ToString();
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
            texDocumento.Clear();
            texNombreCom.Clear();
            texCorreo.Clear();
            texClave.Clear();
            texConfiClave.Clear();
            coRol.SelectedIndex = 0;
            coEstado.SelectedIndex = 0;

            texDocumento.Select();
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
                    texNombreCom.Text = DgvData.Rows[i].Cells["NombreCompleto"].Value.ToString();
                    texCorreo.Text = DgvData.Rows[i].Cells["Correo"].Value.ToString();
                    texClave.Text = DgvData.Rows[i].Cells["Clave"].Value.ToString();
                    texConfiClave.Text = DgvData.Rows[i].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo op in coRol.Items)
                    {
                        if (Convert.ToInt32(op.Valor) == Convert.ToInt32(DgvData.Rows[i].Cells["IdRol"].Value))
                        {
                            int indiceCo = coRol.Items.IndexOf(op);
                            coRol.SelectedIndex = indiceCo;
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
            if(Convert.ToInt32(texId.Text) != 0)
            {
                if(MessageBox.Show("¿Desea eliminar el usuario?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Usuario user = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(texId.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(user, out Mensaje);

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

            if(DgvData.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in DgvData.Rows)
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
