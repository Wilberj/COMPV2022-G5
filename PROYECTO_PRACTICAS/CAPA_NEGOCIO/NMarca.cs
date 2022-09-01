using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class NMarca
    {
        private string TableName = "MARCA";
        public int IdMarca { get; set; }
        public string Marca { get; set; } 
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Object Save(NMarca Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdMarca == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdMarca");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetMarca(NMarca Inst)
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
