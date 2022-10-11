using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using Newtonsoft.Json;

namespace CAPA_NEGOCIO
{
    public class DevolucionesVenta
    {
        private string TableName = "DEVOLUCIONES";
        public int IdDevolucion { get; set; }
        public int IdCliente { get; set; }
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public decimal Total{ get; set; }

        public List<Object> DetallesV = new List<Object>();

        public Object Save(DevolucionesVenta Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdDevolucion == -1)
                {
                    int iddevolucion = Convert.ToInt32(SqlADOConexion.SQLM.InsertObject(TableName, Inst));
                    foreach (Object Detalle in Inst.DetallesV)
                    {
                        DetalleDV DV = new DetalleDV();
                        DV.IdDetalleDV = -1;
                        DV.IdDevolucionVenta = iddevolucion;
                        DV.IdProducto = (JsonConvert.DeserializeObject<DetalleDV>(Detalle.ToString())).IdProducto;
                        DV.IdInventario = (JsonConvert.DeserializeObject<DetalleDV>(Detalle.ToString())).IdInventario;
                        DV.Cantidad = (JsonConvert.DeserializeObject<DetalleDV>(Detalle.ToString())).Cantidad;
                        DV.Total = (JsonConvert.DeserializeObject<DetalleDV>(Detalle.ToString())).Total;
                        DV.Estado = (JsonConvert.DeserializeObject<DetalleDV>(Detalle.ToString())).Estado;

                        DV.TraerIdDV(DV);

                        NInventario InvenA = new NInventario();

                        var InventarioCant = (JsonConvert.DeserializeObject<DetalleDV>(Detalle.ToString())).Cantidad;
                        var IdProducto = (JsonConvert.DeserializeObject<DetalleDV>(Detalle.ToString())).IdProducto;
                        InvenA.DisminuirStock(InventarioCant, IdProducto);

                        Ventas V = new Ventas();
                        V.ANULAR(IdVenta);
                    }
                    return true;

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdDevolucion");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Object TraerDevolucion(NInventario Inst)
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
