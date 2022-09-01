using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class RolUsuario
    {


        private string TableName = "ROL";
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public string Descripcion { get; set; }
        


        public Object Save(RolUsuario Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdRol == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdRol");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetRol(RolUsuario Inst)
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

