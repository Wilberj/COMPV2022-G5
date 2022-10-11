﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class BodegaProductosDan
    {
        private string TableName = "BODEGAPRODUCTOSD";
        public int IdBodegaDanados {get;set;}
       public int  IdInventario {get;set;}
       public int IdBodega {get;set;}
       public int IdProducto {get;set;}
       public int  IdUsuario {get;set;}
       public int  IdTalla {get;set;}
       public int  IdMarca {get;set;}
       public DateTime  Fecha {get;set;}
       public string  Descripcion {get;set;}
       public string  CodigoProducto {get;set;}
       public int  Cantidad {get;set;}

        public Object TraerIdDBodega(BodegaProductosDan Inst)
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
