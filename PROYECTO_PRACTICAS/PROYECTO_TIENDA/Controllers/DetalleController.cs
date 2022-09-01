using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CAPA_NEGOCIO;

namespace PROYECTO_TIENDA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        [HttpPost]

        public Object VerDetalleCompra()
        {
            List<Object> Response = new List<Object>();
            DetalleCompra Inst = new DetalleCompra();
            Response.Add(Inst.TraerDetalleCompra(Inst));

            NProducto pro = new NProducto();
            Response.Add(pro.GetProducto(pro));

            return Response;

        }
    }
}

