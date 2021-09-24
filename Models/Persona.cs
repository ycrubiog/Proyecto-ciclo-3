using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAgendarCitas.Models
{
    public class Persona
    {
        public int Id { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
   
        public Persona(int Id,string Cedula,string Nombre,string Apellido)
        {
            this.Id = Id;
            this.Cedula  = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }
    
    }

   



}
