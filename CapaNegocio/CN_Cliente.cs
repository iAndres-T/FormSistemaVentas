using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente obj_Cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return obj_Cliente.Listar();
        }

        public int Registrar(Cliente client, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (client.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (client.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (client.Correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }

            if(client.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
                return 0;
            else
                return obj_Cliente.Registrar(client, out Mensaje);
        }

        public bool Editar(Cliente client, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (client.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (client.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (client.Correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }

            if (client.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
                return false;
            else
                return obj_Cliente.Editar(client, out Mensaje);
        }

        public bool Eliminar(Cliente client, out string Mensaje)
        {
            return obj_Cliente.Eliminar(client, out Mensaje);
        }
    }
}
