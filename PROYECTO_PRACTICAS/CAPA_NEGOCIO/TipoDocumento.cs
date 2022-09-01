using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
   public class TipoDocumento
    {
        public string TableName = "TIPODOCUMENTO";

        public int IdDocumento { get; set; }
        public string Documento { get; set; }

        public Object Agregar(TipoDocumento Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object Mostrar(TipoDocumento Inst)
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
