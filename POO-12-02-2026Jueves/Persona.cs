using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_12_02_2026Jueves
{
    public class Persona
    {
        public Persona() { }

        public int IdPersona { get; set; }
        public string Nombres { get; set; } // El atributo es "Public" entonces puedo utilizar el "get y set"
		public string Apellidos { get; set; }
        public string CorreoElectronico {  get; set; }



    }
}
