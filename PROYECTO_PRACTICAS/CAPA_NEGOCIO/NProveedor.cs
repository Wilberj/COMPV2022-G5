using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class NProveedor
    {
        public string TableName = "PROVEEDORES";
        public int IdProveedor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }

        public Object Insertar(NProveedor Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdProveedor == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdProveedor");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Object TraerProveedor(NProveedor Inst)
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
