using CAPA_DATOS;
using System;

namespace CAPA_NEGOCIO
{
    public class NInventario
    {
        private string TableName = "INVENTARIO";
        //public string VerCompra = "SP_VER_INVENTARIO";
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Descripcion { get; set; }
        public int IdBodega { get; set; }
        public int IdMarca { get; set; }
        public int IdTalla { get; set; }
        public int IdTransMedida { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockMaximo { get; set; }
        public int StockActual { get; set; }

        public Object Save(NInventario Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdInventario == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdInventario");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public object ActStock(int cant, int id)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "123");


                return SqlADOConexion.SQLM.ActualizarStock(cant, id);


            }
            catch (Exception)
            {
                throw;
            }
        }

        public object DisminuirStock(decimal cant, int id)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "123");


                return SqlADOConexion.SQLM.DisminuirStock(cant, id);


            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetInventario(NInventario Inst)
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

        //public object TraerInformeInventario(NInventario Intv)
        //{
        //    try
        //    {
        //        SqlADOConexion.IniciarConexion("sa", "1234");
        //        return SqlADOConexion.SQLM.TakeListWithProcedure(VerCompra, Intv);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}