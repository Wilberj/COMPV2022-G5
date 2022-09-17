using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class NuevaAsignacionM
    {
        public string TableName = "NUEVAASIGNACION";
        public int IdNAsignacion { get; set; }
        public int IdMedida { get; set; }
        public string NuevaAsignacion { get; set; }

        public Object Insertar(NuevaAsignacionM Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdNAsignacion == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdNAsignacion");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Object TraerAbreviacion(NuevaAsignacionM Inst)
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
