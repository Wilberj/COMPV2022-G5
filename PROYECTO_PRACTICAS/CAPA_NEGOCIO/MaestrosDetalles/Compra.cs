using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using Newtonsoft.Json;

namespace CAPA_NEGOCIO
{
    public class Compra
    {
        public string TableName = "COMPRA";
        
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdProveedor { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

        public List<Object> Detalles = new List<Object>();

        public Object Insertar(Compra Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdCompra == -1)
                {
                    int idcompra = Convert.ToInt32(SqlADOConexion.SQLM.InsertObject(TableName, Inst));
                    foreach (Object Detalle in Inst.Detalles)
                    {
                        DetalleCompra NewId = new DetalleCompra();
                        NewId.IdDetalleCompra = -1; /*(JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).IdDetalleCompra;*/
                        NewId.IdCompra = idcompra;
                        NewId.IdInventario = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).IdInventario;
                        NewId.IdProducto = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).IdProducto;
                        NewId.Precio = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).Precio;
                        NewId.Cantidad = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).Cantidad;
                        NewId.IdMedida = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).IdMedida;
                        NewId.Subtotal = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).Subtotal;
                        NewId.IVA = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).IVA;
                        NewId.Descuento= (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).Descuento;
                        NewId.Total = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).Total;

                        NewId.TraerIdCompra(NewId);

                        NInventario InvenA = new NInventario();//instancia de inventario
                        var InventarioCant = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).Cantidad;
                        var IdProducto = (JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).IdProducto;
                        // //var ExistenciaActual = Convert.ToInt32(InvenA.StockActual); //igualando a stock actual de inventario
                        // //var stockActualizado = ExistenciaActual + cantidadD;// operacion para aumentar stock
                        // //var IdP = NewId.Producto; //id de este producto insertado en detalle
                        InvenA.ActStock(InventarioCant, IdProducto);
                    }
                    return true;
                    // return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdCompra");
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        public Object TraerCompra(Compra Inst)
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
