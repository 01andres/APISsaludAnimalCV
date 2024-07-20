using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APISsaludAnimalClnicaVeterinatia.Models
{
    public class detalleServicio
    {
        public int idDetalleServicio { get; set; }
        public DateTime fechaServicio { get; set; }
        public int nroCita { get; set; }
        public int idTipoServicio { get; set; }
        public string idNombreMascota { get; set; }



    }
}