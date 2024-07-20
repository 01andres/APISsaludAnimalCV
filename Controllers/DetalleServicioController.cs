using APISsaludAnimalClnicaVeterinatia.Data;
using APISsaludAnimalClnicaVeterinatia.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APISsaludAnimalClnicaVeterinatia.Controllers
{
    public class DetalleServicioController : ApiController
    {
        // GET api/<controller>
        public List<detalleServicio> Get()
        {
            return detalleServicioData.Listar();
        }

        // GET api/<controller>/5
        public List<detalleServicio> Get(string id)
        {
            return detalleServicioData.Consultar(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] detalleServicio oServicio)
        {
            return detalleServicioData.registardetalleServicio(oServicio);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] detalleServicio oServicio)
        {
            return detalleServicioData.actualizardetalleServicio(oServicio);
        }

        // DELETE api/<controller>/5
        public bool Delete(detalleServicio oServicio)
        {
            return detalleServicioData.borrardetalleServicio(oServicio);
        }
    }
}