using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio obj_Negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return obj_Negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio nego, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (nego.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Negocio\n";
            }

            if (nego.RUC == "")
            {
                Mensaje += "Es necesario el numero RUC del Negocio\n";
            }

            if (nego.Direccion == "")
            {
                Mensaje += "Es necesario la direccion del Negocio\n";
            }

            if (Mensaje != string.Empty)
                return false;
            else
                return obj_Negocio.GuardarDatos(nego, out Mensaje);
        }

        public byte[] ObtenerLogo(out bool Respuesta)
        {
            return obj_Negocio.ObtenerLogo(out Respuesta);
        }

        public bool ActualizarLogo(byte[] Image, out string Mensaje)
        {
            return obj_Negocio.ActualizarLogo(Image, out Mensaje);
        }
    }
}
