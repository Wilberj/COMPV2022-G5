using System;
using System.Collections.Generic;
using System.Text;
namespace CAPA_DATOS
{
    public class SqlADOConexion
    {
        static string UserSQLConexion = "";
        public static SqlServerGDatos SQLM;
        static public bool IniciarConexion(string user, string password)
        {
            try
            {
                UserSQLConexion = "Data Source=.;Initial Catalog=PRUEBA4;Integrated Security=True";
                SQLM = new SqlServerGDatos(UserSQLConexion);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }//User ID=sa;Password=1234
}
