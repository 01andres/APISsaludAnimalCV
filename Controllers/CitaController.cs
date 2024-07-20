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
    public class CitaController : ApiController
    {
        // GET api/<controller>
        public List<Cita> Get()
        {
            return CitaData.Listar();
        }

        // GET api/<controller>/5
        public List<Cita> Get(string id)
        {
            return CitaData.Consultar(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Cita oCita)
        {
            return CitaData.registrarCita(oCita);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Cita oCita)
        {
            return CitaData.actualizarCita(oCita);
        }

        // DELETE api/<controller>/5
        public bool Delete(Cita oCita)
        {
            return CitaData.borrarrCita(oCita);
        }
    }
}