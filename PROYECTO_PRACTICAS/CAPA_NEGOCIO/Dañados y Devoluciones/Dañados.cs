using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using Newtonsoft.Json;

namespace CAPA_NEGOCIO
{
    public class Dañados
    {
        private string TableName = "PRODUCTO_DAÑADOS";
        public int IdDañados { get; set; }
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }



        public Object Save(Dañados Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdDañados==-1)
                {
                    Convert.ToInt32(SqlADOConexion.SQLM.InsertObject(TableName, Inst));

                    NInventario InvenA = new NInventario();//instancia de inventario
                    var InventarioCant = Cantidad;
                    var IdProd = IdProducto;
                    InvenA.DisminuirStock(InventarioCant, IdProd);
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Object GetDañado(Dañados Inst)
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
