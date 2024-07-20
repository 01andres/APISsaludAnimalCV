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
    public class MascotaController : ApiController
    {
        // GET api/<controller>
        public List<Mascota> Get()
        {
            return MascotaData.listar() ;
        }

        // GET api/<controller>/5
        public List<Mascota> Get(string id)
        {
            return MascotaData.Consultar(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Mascota oMascota)
        {
            return MascotaData.registrarMascota(oMascota);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Mascota oMascota)
        {
            return MascotaData.actualizarMascota(oMascota);
        }

        // DELETE api/<controller>/5
        public bool Delete(Mascota oMascota)

        {
            return MascotaData.borrarMascota(oMascota);
        }
    }
}