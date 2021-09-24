using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAgendarCitas.Models
{
    public class Medico : Persona
    {
        public string numeroConsultorio { get; set; }
    
        public Medico(int Id,string Cedula,string Nombre,string Apellido,string numeroConsultorio) : base(Id,Cedula,Nombre,Apellido)
        {
            this.numeroConsultorio = numeroConsultorio;
        }
    }
}
