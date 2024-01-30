using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor obj_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return obj_Proveedor.Listar();
        }

        public int Registrar(Proveedor client, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (client.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (client.RazonSocial == "")
            {
                Mensaje += "Es necesaria la razon social del Proveedor\n";
            }

            if (client.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }

            if (client.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
                return 0;
            else
                return obj_Proveedor.Registrar(client, out Mensaje);
        }

        public bool Editar(Proveedor client, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (client.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (client.RazonSocial == "")
            {
                Mensaje += "Es necesaria la razon social del Proveedor\n";
            }

            if (client.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }

            if (client.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
                return false;
            else
                return obj_Proveedor.Editar(client, out Mensaje);
        }

        public bool Eliminar(Proveedor client, out string Mensaje)
        {
            return obj_Proveedor.Eliminar(client, out Mensaje);
        }
    }
}
