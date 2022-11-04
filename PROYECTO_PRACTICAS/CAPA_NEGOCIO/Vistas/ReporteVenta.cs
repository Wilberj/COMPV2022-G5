using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class ReporteVenta
    {
      
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public string Usuario { get; set; }
        public string Cliente { get; set; }
        public string Marca { get; set; }
        public string Talla { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public List<Object> Params { get; set; }

        public Object TraerInforme(ReporteVenta Inst)
        {
            try
            {
                List<Object> SqlParams = new List<Object>();
                SqlParams.Add(Convert.ToDateTime(Params[0]));
                SqlParams.Add(Convert.ToDateTime(Params[1]));
                SqlADOConexion.IniciarConexion("sa", "1234");
                var Informe = SqlADOConexion.SQLM.TakeListWithProcedureV("InformeVenta", Inst, SqlParams);
                return Informe;
            }
            catch (Exception)
            {
                throw;
            }
        }

       
    }
}
