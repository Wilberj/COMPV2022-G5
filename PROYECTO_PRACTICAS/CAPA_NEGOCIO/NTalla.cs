using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class NTalla
    {
        private string TableName = "TALLA";
        public int IdTalla { get; set; }
        public string Talla { get; set; }

        public Object Save(NTalla Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdTalla == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdTalla");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetTalla(NTalla Inst)
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
