using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class DetalleDanados
    {
<<<<<<< HEAD
       
            public string TableName = "DETALLEDANADOS";
            public int IdDetalleD { get; set; }
            public int IdDanados { get; set; }
            public int IdInventario { get; set; }
            public int IdProducto { get; set; }
            public string CodigoProducto { get; set; }
            public int Cantidad { get; set; }
            public int IdTalla { get; set; }
            public int IdMarca { get; set; }
            public int IdBodega { get; set; }
=======

        public string TableName = "DETALLEDANADOS";
        public int IdDetalleD { get; set; }
        public int IdDanados { get; set; }
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public int IdTalla { get; set; }
        public int IdMarca { get; set; }
        public int IdBodega { get; set; }
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19



        public Object TraerDetalleD(DetalleDanados Inst)
<<<<<<< HEAD
            {
                try
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                catch (Exception)
                {

                    throw;
                }
            }
    }
}
=======
        {
            try
            {
                return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19
