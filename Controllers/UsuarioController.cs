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
    public class UsuarioController : ApiController
    {


        // GET api/<controller>
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }

        // GET api/<controller>/5
        public List<Usuario> Get(string id)
        {
            return UsuarioData.Consultar(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Usuario oUsuario)
        {
            return UsuarioData.RegistarUsuario(oUsuario);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Usuario oUsuario)
        {
            return UsuarioData.actualizarUsuario(oUsuario);
        }

        // DELETE api/<controller>/5
        public bool Delete(Usuario oUsuario)
        {
            return UsuarioData.borrarUsuario(oUsuario);
        }
    }
}