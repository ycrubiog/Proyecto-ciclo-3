using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendarCitas.Models
{
    public class Persona
    {

        [Key]
        public int Id { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }


        public string Apellido { get; set; } 


        public Persona(int Id,string Cedula,string Nombre,string Apellldio)
        {
            this.Id = Id;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

    }
}
