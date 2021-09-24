using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAgendarCitas.Models
{
    public class Paciente : Persona
    {
        public string Telefono { get; set; }

        public Paciente(int Id,string Cedula,string Nombre,string Apellido,string Telefono) : base(Id,Cedula,Nombre,Apellido)
        {
            this.Telefono = Telefono;
        }

    }


}
