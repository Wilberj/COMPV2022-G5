using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using Newtonsoft.Json;

namespace CAPA_NEGOCIO
{
    public class ProductosDan
    {
        private string TableName = "PRODUCTO_DAÑADOS";
        public int IdDanados { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }

        public List<Object> Detalles = new List<Object>();
        public Object Save(ProductosDan Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdDanados == -1)
                {
                    int iddan = Convert.ToInt32(SqlADOConexion.SQLM.InsertObject(TableName, Inst));
                    foreach (Object Detalle in Inst.Detalles)
                    {
                        DetalleDanados NewId = new DetalleDanados();
                        NewId.IdDetalleD = -1; /*(JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).IdDetalleCompra;*/
                        NewId.IdDanados = iddan;
                        NewId.IdInventario = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdInventario;
                        NewId.IdProducto = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdProducto;
                        NewId.CodigoProducto = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).CodigoProducto;
                        NewId.Cantidad = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).Cantidad;
                        NewId.IdTalla = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdTalla;
                        NewId.IdMarca = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdMarca;
                        NewId.IdBodega = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdBodega;

                        NewId.TraerDetalleD(NewId);


                        DetalleBodega DB = new DetalleBodega();

                        int idusuario = IdUsuario;
                        DateTime fecha = Fecha;
                        string descripcion = Descripcion;
                       

                        DB.IdBodegaDanados = -1; /*(JsonConvert.DeserializeObject<DetalleCompra>(Detalle.ToString())).IdDetalleCompra;*/
                        DB.IdInventario = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdInventario;
                        DB.IdBodega = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdBodega;
                        DB.IdProducto = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdProducto;
                        DB.IdUsuario = idusuario;
                        DB.IdTalla = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdTalla;
                        DB.IdMarca = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdMarca;
                        DB.Fecha = fecha;
                        DB.Descripcion = descripcion;
                        DB.CodigoProducto = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).CodigoProducto;
                        DB.Cantidad = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).Cantidad;

                        DB.TraerDetalleB(DB);

                        NInventario InvenA = new NInventario();//instancia de inventario
                        var InventarioCant = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).Cantidad;
                        var IdProducto = (JsonConvert.DeserializeObject<DetalleDanados>(Detalle.ToString())).IdProducto;

                        InvenA.DisminuirStock(InventarioCant, IdProducto);
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

        public Object GetDañado(ProductosDan Inst)
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
