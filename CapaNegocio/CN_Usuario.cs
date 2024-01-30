using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario obj_Usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return obj_Usuario.Listar();
        }

        public int Registrar(Usuario user, out string Mensaje)
        {
            Mensaje = string.Empty;

            if(user.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }

            if(user.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if(user.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }

            if (Mensaje != string.Empty)
                return 0;
            else
                return obj_Usuario.Registrar(user, out Mensaje);
        }

        public bool Editar(Usuario user, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (user.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }

            if (user.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (user.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }

            if (Mensaje != string.Empty)
                return false;
            else
                return obj_Usuario.Editar(user, out Mensaje);
        }

        public bool Eliminar(Usuario user, out string Mensaje)
        {
            return obj_Usuario.Eliminar(user, out Mensaje);
        }
    }
}
