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
    public class CN_Venta
    {
        private CD_Venta obj_Venta = new CD_Venta();

        public int ObtenerCorrelativo()
        {
            return obj_Venta.ObtenerCorrelativo();
        }

        public bool Registrar(Venta obj, DataTable detalleVenta, out string Mensaje)
        {
            return obj_Venta.Registrar(obj, detalleVenta, out Mensaje);
        }

        public bool RestarStock(int id, int cantidad)
        {
            return obj_Venta.RestarStock(id, cantidad);
        }
        
        public bool SumarStock(int id, int cantidad)
        {
            return obj_Venta.SumarStock(id, cantidad);
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta venta = obj_Venta.ObtenerVenta(numero);

            if(venta.IdVenta != 0)
            {
                List<Detalle_Venta> detalleVenta = obj_Venta.ObtenerDetalleVenta(venta.IdVenta);
                venta.oDetalleVenta = detalleVenta;
            }
            return venta;
        }
    }
}
