using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO.Vistas
{
    public class VistaInventario
    {
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Marca { get; set; }
        public string Talla { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockActual { get; set; }
        public Object TraerInventario(MostrarInventario Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                var vista = SqlADOConexion.SQLM.TakeListWithProcedure("SP_MOSTRAR_INV_MAESTROS", Inst);
                return vista;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
