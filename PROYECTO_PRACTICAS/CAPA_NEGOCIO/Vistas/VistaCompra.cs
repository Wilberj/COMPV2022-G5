using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class VistaCompra
    {
       
            public int IdCompra { get; set; }
            public DateTime Fecha { get; set; }
            public string Descripcion { get; set; }
            public string Proveedor { get; set; }
            public string NombreProducto { get; set; }
            public string Marca { get; set; }
            public string Talla { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Subtotal { get; set; }
            public decimal IVA{ get; set; }
            public decimal Descuento { get; set; }
            public decimal Total { get; set; }
            public string Estado { get; set; }

        public Object TraerInfoCompra(VistaCompra Inst)
            {
                try
                {
                    SqlADOConexion.IniciarConexion("sa", "1234");
                    var vista = SqlADOConexion.SQLM.TakeListWithProcedure("SP_INFORMECOMPRA", Inst);
                    return vista;
                }
                catch (Exception)
                {

                    throw;
                }

            }

     }
    
}
