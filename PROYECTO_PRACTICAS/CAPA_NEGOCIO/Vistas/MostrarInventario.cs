using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class MostrarInventario
    {
            public int IdInventario { get; set; }
            public int IdProducto { get; set; }
            public string Producto { get; set; }
            public string CodigoProducto { get; set; }
            public DateTime FechaRegistro { get; set; }
            public string Bodega { get; set; }
            public string Marca { get; set; }
            public string Talla { get; set; }
            public decimal PrecioCompra { get; set; }
            public decimal PrecioVenta { get; set; }
            public string Medida { get; set; }
            public int StockMinimo { get; set; }
            public int StockMaximo { get; set; }
            public int StockActual { get; set; }
            public Object TraerInvProc(MostrarInventario Inst)
            {
                try
                {
                    SqlADOConexion.IniciarConexion("sa", "1234");
                    var vista = SqlADOConexion.SQLM.TakeListWithProcedure("SP_MOSTRARINVENTARIO", Inst);
                    return vista;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }

