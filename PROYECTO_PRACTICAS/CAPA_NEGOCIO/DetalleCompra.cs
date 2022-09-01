using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
   public class DetalleCompra
    {
        public string TableName = "DETALLECOMPRA";
        public int IdDetalleCompra { get; set; }
        public int Compra { get; set; }
        public int IdProducto { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Medida { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Object TraerIdCompra(DetalleCompra Inst)
        {
            try
            {
                return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Object InsertarDetalle(DetalleCompra Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdDetalleCompra == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdDetalleCompra");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Object TraerDetalleCompra(DetalleCompra Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, Inst, null);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
