using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria obj_Categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return obj_Categoria.Listar();
        }

        public int Registrar(Categoria catego, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (catego.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
                return 0;
            else
                return obj_Categoria.Registrar(catego, out Mensaje);
        }

        public bool Editar(Categoria catego, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (catego.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
                return false;
            else
                return obj_Categoria.Editar(catego, out Mensaje);
        }

        public bool Eliminar(Categoria catego, out string Mensaje)
        {
            return obj_Categoria.Eliminar(catego, out Mensaje);
        }
    }
}
