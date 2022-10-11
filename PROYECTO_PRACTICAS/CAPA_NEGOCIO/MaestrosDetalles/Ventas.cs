using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using Newtonsoft.Json;

namespace CAPA_NEGOCIO
{
    public class Ventas
    {
        public string TableName = "VENTA";


        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cliente { get; set; }
        public int IdUsuario { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

        public List<Object> DetallesV = new List<Object>();

        public Object Insertar(Ventas Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdVenta == -1)
                {
                    int idventa = Convert.ToInt32(SqlADOConexion.SQLM.InsertObject(TableName, Inst));
                    foreach (Object Detalle in Inst.DetallesV)
                    {
                        DetalleVenta NewId = new DetalleVenta();
                        NewId.IdDetalleVenta = -1; 
                        NewId.IdVenta = idventa;
                        NewId.IdProducto = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).IdProducto;
                        NewId.IdInventario = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).IdInventario;
                        NewId.Cantidad = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).Cantidad;
                        NewId.IdMedida = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).IdMedida;
                        NewId.Precio = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).Precio;
                        NewId.Subtotal = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).Subtotal;
                        NewId.IVA = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).IVA;
                        NewId.Descuento = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).Descuento;
                        NewId.Total = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).Total;

                        NewId.TraerIdVenta(NewId);

                        NInventario InvenA = new NInventario();

                        var InventarioCant = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).Cantidad;
                        var IdProducto = (JsonConvert.DeserializeObject<DetalleVenta>(Detalle.ToString())).IdProducto;
                        InvenA.DisminuirStock(InventarioCant, IdProducto);
                    }
                    return true;
                    
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdVenta");
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        public Object TraerVenta(Ventas Inst)
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

        public object ANULAR(int id)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "123");


                return SqlADOConexion.SQLM.AnularVenta(id);


            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
