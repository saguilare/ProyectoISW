using System;
using System.Collections.Generic;
using System.Web.Http;
using ProyectoISW.Models;

namespace ProyectoISW.Controllers
{
    public class CasaController : ApiController
    {
        [Route("api/casa")]
        [HttpGet]
        public List<Casa> Casa()
        {
            Casa h1 = new Casa { id = "0", descripcion = "Residencial" };
            Casa h2 = new Casa { id = "1", descripcion = "Condominio" };
            Casa h3 = new Casa { id = "2", descripcion = "Casa Playa" };
            Casa h4 = new Casa { id = "3", descripcion = "Cabana" };



            List<Casa> Casas = new List<Casa>();
            Casas.Add(h1);
            Casas.Add(h2);
            Casas.Add(h3);
            Casas.Add(h4);
            return Casas;
        }


    }

}
