using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto obj_Producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return obj_Producto.Listar();
        }

        public int Registrar(Producto produ, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (produ.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (produ.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (produ.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
                return 0;
            else
                return obj_Producto.Registrar(produ, out Mensaje);
        }

        public bool Editar(Producto produ, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (produ.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (produ.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (produ.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
                return false;
            else
                return obj_Producto.Editar(produ, out Mensaje);
        }

        public bool Eliminar(Producto produ, out string Mensaje)
        {
            return obj_Producto.Eliminar(produ, out Mensaje);
        }
    }
}
