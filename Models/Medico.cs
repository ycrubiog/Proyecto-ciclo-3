using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendarCitas.Models
{
    public class Medico : Persona
    {
        public string numeroConsultorio { get; set; }

        public Medico(int Id, string Cedula, string Nombre, String Apellido, string NumeroConsultorio) : base(Id, Cedula, Nombre, Apellido)
        {
            this.numeroConsultorio = numeroConsultorio;
        }
    }
}
