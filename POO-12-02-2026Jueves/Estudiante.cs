using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_12_02_2026Jueves
{
	public class Estudiante : Persona
	{
		public Estudiante() { }

		public int IdEstudiante { get; set; }
		public string Carrera { get; set; }
		public int Semestre { get; set; }

		public string ObtenerInformacion()
		{
			return "Estudiante: " + Nombres + " " + Apellidos +
				   " | Carrera: " + Carrera +
				   " | Semestre: " + Semestre +
				   " | Correo: " + CorreoElectronico;
		}
	}
}