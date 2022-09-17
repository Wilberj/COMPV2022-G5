using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class VistaCmpraDetalle
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public string Medida { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public Object TraerCompraConProc(VistaCmpraDetalle Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                var vista = SqlADOConexion.SQLM.TakeListWithProcedure("SP_MOSTRARCOMPRA", Inst);
                return vista;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

//public int IdInventario { get; set; }
//public int IdProducto { get; set; }
//public string Producto { get; set; }
//public string CodigoProducto { get; set; }
//public DateTime FechaRegistro { get; set; }
//public string Bodega { get; set; }
//public string Marca { get; set; }
//public string Talla { get; set; }
//public decimal PrecioCompra { get; set; }
//public decimal PrecioVenta { get; set; }
//public string Medida { get; set; }
//public int StockMinimo { get; set; }
//public int StockMaximo { get; set; }
//public int StockActual { get; set; }