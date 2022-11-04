using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class ReportePMV
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public Object TraerPMV(ReportePMV Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                var vista = SqlADOConexion.SQLM.TakeListWithProcedure("ProdMasVendido", Inst);
                return vista;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}
