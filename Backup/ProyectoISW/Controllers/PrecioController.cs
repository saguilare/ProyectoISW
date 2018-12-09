using System;
using System.Collections.Generic;
using System.Web.Http;
using ProyectoISW.Models;

namespace ProyectoISW.Controllers
{
    public class PrecioController : ApiController
    {
        [Route("api/precio/{id}")]
        [HttpGet]
        public Precio Precio(string id)
        {
            Precio precio = new Precio();
            switch (id)
            {
                case "1":
                    precio = new Precio { id = "1", descripcion = "San Jose", precio = "200" };
                    break;
                case "2":
                    precio = new Precio { id = "2", descripcion = "Alajuela", precio = "150" };
                    break;
                case "3":
                    precio = new Precio { id = "3", descripcion = "Heredia", precio = "150" };
                    break;
                case "4":
                    precio = new Precio { id = "4", descripcion = "Cartago", precio = "100" };
                    break;
                case "5":
                    precio = new Precio { id = "5", descripcion = "Guanacaste", precio = "100" };
                    break;
                case "6":
                    precio = new Precio { id = "6", descripcion = "Puntarenas", precio = "100" };
                    break;
                case "7":
                    precio = new Precio { id = "7", descripcion = "Limon", precio = "100" };
                    break;
                default:
                    precio = new Precio { id = "1", descripcion = "San Jose", precio = "100" };
                    break;
            }

            return precio;
        }
    }
}
