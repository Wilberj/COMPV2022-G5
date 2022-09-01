using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class Bodega
    {
        private string TableName = "BODEGA";
        public int IdBodega { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }

        public Object GetBodega(Bodega Inst)
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
