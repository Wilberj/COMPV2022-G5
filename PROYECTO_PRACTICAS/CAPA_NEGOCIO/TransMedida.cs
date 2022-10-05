using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class TransMedida
    {
        public string TableName = "TRANSFORMARMEDIDA";
        public int IdTransMedida { get; set; }
        public int IdMedida { get; set; }
        public string NuevaAsignacion { get; set; }
        public string Equivalencia { get; set; }
        public string Estado { get; set; }


        public Object Insertar(TransMedida Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdTransMedida == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdTransMedida");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Object TraerTransMedida(TransMedida Inst)
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
