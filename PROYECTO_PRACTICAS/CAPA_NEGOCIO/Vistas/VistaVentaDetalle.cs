using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class VistaVentaDetalle
    {
        public int IdVenta { get; set; }
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Clientes { get; set; }
        public string Medida { get; set; }
        public string Usuarios { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public Object TraerVentaConProc(VistaVentaDetalle Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                var vista = SqlADOConexion.SQLM.TakeListWithProcedure("SP_MOSTRARVENTA", Inst);
                return vista;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
