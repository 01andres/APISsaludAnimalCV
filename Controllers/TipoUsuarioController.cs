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
    public class TipoUsuarioController : ApiController
    {
        // GET api/<controller>
        public List<Tipo_usuario> Get()
        {
            return TipoUsuarioData.Listar();
        }

        // GET api/<controller>/5
        public List<Tipo_usuario> Get( string  id)
        {
            return TipoUsuarioData.Consultar(id);
        }

        // POST api/<controller>
        public bool  Post([FromBody] Tipo_usuario otipoUsuario)
        {
            return TipoUsuarioData.registrarTipoUsuario(otipoUsuario); 
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Tipo_usuario oTipoUsuario)
        {
            return TipoUsuarioData.actualizarTipoUsuario(oTipoUsuario);
        }

        // DELETE api/<controller>/5
        public bool Delete(Tipo_usuario otipoUsuario)
        {
            return TipoUsuarioData.borrarTipoUsuario(otipoUsuario);
        }
    }
}