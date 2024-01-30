using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra obj_Compra = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return obj_Compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable detalleCompra, out string Mensaje)
        {
            return obj_Compra.Registrar(obj, detalleCompra,out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra compra = obj_Compra.ObtenerCompra(numero);

            if(compra.IdCompra != 0)
            {
                List<Detalle_Compra> detalleCompra = obj_Compra.ObtenerDetalleCompra(compra.IdCompra);
                compra.oDetalleCompra = detalleCompra;
            }
            return compra;
        }        
    }
}
