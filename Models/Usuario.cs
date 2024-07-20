using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APISsaludAnimalClnicaVeterinatia.Models
{
    public class Usuario
    {
        public int idDocumentoUsuario { get; set;  }
        public string nombreUsuario { get; set; }
        public string apellido {  get; set; }
        public string contacto { get; set; }
        public string mail {  get; set; }
        public string contrasenia { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int idTipoUsuario { get; set; }
    }
}