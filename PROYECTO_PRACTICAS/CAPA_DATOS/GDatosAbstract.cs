using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CAPA_DATOS
{
    public abstract class GDatosAbstract
    {
        protected IDbConnection SQLMCon;
        protected abstract IDbConnection CrearConexion(string cadena);
        protected abstract IDbCommand ComandoSql(string comandoSql, IDbConnection connection);
        protected abstract IDataAdapter CrearDataAdapterSql(string comandoSql, IDbConnection connection);
        protected abstract IDataAdapter CrearDataAdapterSql(IDbCommand comandoSql);
        public object ExcuteSqlQuery(string strQuery)
        {
            try
            {
                SQLMCon.Open();
                var com = ComandoSql(strQuery, SQLMCon);
                var scalar = com.ExecuteScalar();
                SQLMCon.Close();
                if (scalar == (object)DBNull.Value)
                {
                    return true;
                }
                else
                {
                    return Convert.ToInt32(scalar);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object InsertObject(string TableName, Object Inst)
        {
            try
            {
                string ColumnNames = "";
                string Values = "";
                Type _type = Inst.GetType(); //para saber que va a leer; obtiene tipo string,date,bool,object
                PropertyInfo[] lst = _type.GetProperties();//obtiene todas las propiedades
                foreach (PropertyInfo oProperty in lst) // lee las propiedades de property info
                {
                    string AtributeName = oProperty.Name; // obtien los nombres id,nombre, descripcion..etc
                    var AtributeValue = oProperty.GetValue(Inst);// el valor de nombre(pedro), descripcion,id etc...

                    if (AtributeValue == null)
                    {
                        continue;
                    }
                    else if (AtributeValue.GetType() == typeof(string))
                    {
                        ColumnNames = ColumnNames + AtributeName.ToString() + ",";
                        Values = Values + "'" + AtributeValue.ToString() + "',";//  
                    }
                    else if (AtributeValue.GetType() == typeof(DateTime))
                    {
                        ColumnNames = ColumnNames + AtributeName.ToString() + ",";
                        Values = Values + "'" + ((DateTime)AtributeValue).ToString("yyyy/dd/MM") + "',";
                    }
                    else if (AtributeValue.GetType() == typeof(decimal))
                    {
                        ColumnNames = ColumnNames + AtributeName.ToString() + ",";
                        Values = Values + AtributeValue.ToString() + ",";
                    }
                    else //yyyy/dd/MM
                    {
                        if ((Int32)AtributeValue != -1)
                        {
                            ColumnNames = ColumnNames + AtributeName.ToString() + ",";
                            Values = Values + AtributeValue.ToString() + ",";
                        }
                    }
                }
                ColumnNames = ColumnNames.TrimEnd(',');
                Values = Values.TrimEnd(',');
                string strQuery = "INSERT INTO " + TableName
                    + "(" + ColumnNames + ") VALUES("
                    + Values + ") SELECT SCOPE_IDENTITY()";
                return ExcuteSqlQuery(strQuery);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object UpdateObject(string TableName, Object Inst, string IdObject)
        {
            try
            {
                string Values = ""; //valores a insertar dentro de la tabla
                Type _type = Inst.GetType();
                PropertyInfo[] lst = _type.GetProperties();
                PropertyInfo prop = lst[0];
                foreach (PropertyInfo oProperty in lst)
                {
                    string AtributeName = oProperty.Name;
                    var AtributeValue = oProperty.GetValue(Inst);
                    if (AtributeName != IdObject)
                    {
                        if (AtributeValue == null)
                        {
                            continue;
                        }
                        else if (AtributeValue.GetType() == typeof(string) || AtributeValue.GetType() == typeof(DateTime))
                        {
                            Values = Values + AtributeName + "= '" + AtributeValue.ToString() + "',";
                        }
                        else
                        {
                            Values = Values + AtributeName + "=" + AtributeValue.ToString() + ",";
                        }
                    }
                    else
                    {
                        prop = oProperty;
                    }

                }
                Values = Values.TrimEnd(',');
                string strQuery = "UPDATE  " +
                    TableName + " SET " +
                    Values + " WHERE " + IdObject + " = " + prop.GetValue(Inst).ToString();
                return ExcuteSqlQuery(strQuery);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object ActualizarStock(int cant, int id)
        {
            try
            {
                //UPDATE INVENTARIO SET StockMaximo=100 WHERE Producto=2
                //update INVENTARIO set StockActual = StockActual + 10 where IdProducto = 1
                string Query = "UPDATE INVENTARIO SET StockActual = StockActual + " + cant + " WHERE IdProducto = " + id;
                return ExcuteSqlQuery(Query);
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
                //UPDATE INVENTARIO SET StockMaximo=100 WHERE Producto=2
                //update INVENTARIO set StockActual = StockActual + 10 where IdProducto = 1
                string Query = "UPDATE INVENTARIO SET StockActual = StockActual - " + cant + " WHERE IdProducto = " + id;

                return ExcuteSqlQuery(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable TraerDatosSQL(string queryString)
        {
            DataSet ObjDS = new DataSet();
            CrearDataAdapterSql(queryString, SQLMCon).Fill(ObjDS);
            return ObjDS.Tables[0].Copy();
        }
        public DataTable TraerDatosSQL(IDbCommand Command)
        {
            DataSet ObjDS = new DataSet();
            CrearDataAdapterSql(Command).Fill(ObjDS);
            return ObjDS.Tables[0].Copy();
        }
        public Object TakeList(string TableName, Object Inst, string? Condicion)
        {
            try
            {
                string CondicionString = "";
                if (Condicion != null)
                {
                    CondicionString = " WHERE " + Condicion;
                }
                string queryString = "SELECT * FROM " + TableName + CondicionString;
                DataTable Table = TraerDatosSQL(queryString);
                List<Object> ListD = ConvertDataTable(Table, Inst); // no se sabe que tipo de dato se va a retornar
                return ListD;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public Object TakeListWithProcedure(string ProcedureName, Object Inst, List<Object> Params)
        //{
        //    try
        //    {
        //        SQLMCon.Open();
        //        var Command = ComandoSql(ProcedureName, SQLMCon);
        //        Command.CommandType = CommandType.StoredProcedure;
        //        SqlCommandBuilder.DeriveParameters((SqlCommand)Command);
        //        SQLMCon.Close();
        //        if (Params.Count != 0)
        //        {
        //            int i = 0;
        //            foreach (var param in Params)
        //            {
        //                var p = (SqlParameter)Command.Parameters[i + 1];
        //                p.Value = param;
        //                i++;
        //            }
        //        }
        //        DataTable Table = TraerDatosSQL(Command);
        //        List<Object> ListD = ConvertDataTable(Table, Inst);
        //        return ListD;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public Object TakeListWithProcedure(string ProcedureName, Object Inst)
        {
            try
            {
                SQLMCon.Open();
                var Command = ComandoSql(ProcedureName, SQLMCon);
                Command.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters((SqlCommand)Command);
                SQLMCon.Close();
                //if (Params.Count != 0)
                //{
                //    int i = 0;
                //    foreach (var param in Params)
                //    {
                //        var p = (SqlParameter)Command.Parameters[i + 1];
                //        p.Value = param;
                //        i++;
                //    }
                //}
                DataTable Table = TraerDatosSQL(Command);
                List<Object> ListD = ConvertDataTable(Table, Inst);
                return ListD;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static List<Object> ConvertDataTable(DataTable dt, Object Inst)
        {
            List<Object> data = new List<Object>();
            foreach (DataRow row in dt.Rows)
            {
                var item = GetItem(row, Inst);
                data.Add(item);
            }
            return data;
        }
        private static Object GetItem(DataRow dr, Object Inst)
        {
            Type temp = Inst.GetType();
            var obj = Activator.CreateInstance(Inst.GetType());//no se sabe quien lo instancia
            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
