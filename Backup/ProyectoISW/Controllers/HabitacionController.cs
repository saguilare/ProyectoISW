using System;
using System.Collections.Generic;
using System.Web.Http;
using ProyectoISW.Models;

namespace ProyectoISW.Controllers
{
   
    public class HabitacionController : ApiController{

        [Route("api/habitacion")]
        [HttpGet]
        public List<Habitacion> Habitacion()
        {
            Habitacion h1 = new Habitacion { id = "0", descripcion = "Sala" };
            Habitacion h2 = new Habitacion { id = "1", descripcion = "Cocina" };
            Habitacion h3 = new Habitacion { id = "2", descripcion = "Dormitorio" };
            Habitacion h4 = new Habitacion { id = "3", descripcion = "Bano" };
            Habitacion h5 = new Habitacion { id = "4", descripcion = "Patio" };
            Habitacion h6 = new Habitacion { id = "5", descripcion = "Cochera" };


            List<Habitacion> habitaciones = new List<Habitacion>();
            habitaciones.Add(h1);
            habitaciones.Add(h2);
            habitaciones.Add(h3);
            habitaciones.Add(h4);
            habitaciones.Add(h5);
            habitaciones.Add(h6);
            return habitaciones;


        }

    }
}
