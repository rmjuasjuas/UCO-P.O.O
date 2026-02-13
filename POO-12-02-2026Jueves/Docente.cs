using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_12_02_2026Jueves
{
	public class Docente : Persona
	{
		public Docente() { }

		public int IdDocente { get; set; }
		public string Materia { get; set; }
		public string TipoContrato { get; set; }

		public string ObtenerInformacion()
		{
			return "Docente: " + Nombres + " " + Apellidos +
				   " | Materia: " + Materia +
				   " | Contrato: " + TipoContrato +
				   " | Correo: " + CorreoElectronico;
		}
	}
}
