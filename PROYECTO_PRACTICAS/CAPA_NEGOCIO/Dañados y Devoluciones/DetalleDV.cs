using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class DetalleDV
    {
        private string TableName = "DETALLE_DEVOLUCIONVENTA";
        public int  IdDetalleDV{get;set;}
        public int  IdDevolucionVenta {get;set;}
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
        public string Estado{ get; set; }


        public Object TraerIdDV(DetalleDV Inst)
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
    }
}
