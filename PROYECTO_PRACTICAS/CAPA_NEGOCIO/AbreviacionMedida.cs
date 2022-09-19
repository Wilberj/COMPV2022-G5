using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    class AbreviacionMedida
    {
        private string TableName = "ABRAVIACIONMEDIDA";
        public int IdAbreviacion { get; set; }
        public int IdMedida { get; set; }
         public string NombreAbreviacion { get; set; }

        public Object Insertar(AbreviacionMedida Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdAbreviacion == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdAbreviacion");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Object TraerAbreviacion(AbreviacionMedida Inst)
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
