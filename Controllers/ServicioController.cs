using APISsaludAnimalClnicaVeterinatia.Data;
using APISsaludAnimalClnicaVeterinatia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APISsaludAnimalClnicaVeterinatia.Controllers
{
    public class ServicioController : ApiController
    {
        // GET api/<controller>
        public List<servicio> Get()
        {
            return servicioData.Listar();
        }

        // GET api/<controller>/5
        public List<servicio> Get (string id)
        {
            return servicioData.Consultar(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] servicio otipoServicio)
        {
            return servicioData.registrarServicio(otipoServicio);
        }

        // PUT api/<controller>/5
        public bool Put ([FromBody] servicio otipoServicio)
        {
            return servicioData.actualizarServicio(otipoServicio);
        }

        // DELETE api/<controller>/5
        public bool Delete(servicio otipoServicio)
        {
            return  servicioData.borrarServicio(otipoServicio);
        }
    }
}