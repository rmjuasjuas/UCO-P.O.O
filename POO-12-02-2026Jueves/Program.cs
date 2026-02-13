using POO_12_02_2026Jueves;

Console.WriteLine("Bienvenido al sistema universitario\n");

// -------------------------------------------------------
// Seccion Estudiantes
// -------------------------------------------------------

List<Estudiante> listaEstudiantes = new List<Estudiante>();

Estudiante estudianteJoseMiguel = new Estudiante();
estudianteJoseMiguel.IdPersona = 1;
estudianteJoseMiguel.IdEstudiante = 1;
estudianteJoseMiguel.Nombres = "Jose Miguel";
estudianteJoseMiguel.Apellidos = "Rios Montoya";
estudianteJoseMiguel.CorreoElectronico = "jomirimo09@hotmail.com";
estudianteJoseMiguel.Carrera = "Ingenieria en Sistemas";
estudianteJoseMiguel.Semestre = 1;

Estudiante estudianteLaura = new Estudiante();
estudianteLaura.IdPersona = 2;
estudianteLaura.IdEstudiante = 2;
estudianteLaura.Nombres = "Laura";
estudianteLaura.Apellidos = "Gomez Restrepo";
estudianteLaura.CorreoElectronico = "laura.gomez@uco.net.co";
estudianteLaura.Carrera = "Medicina";
estudianteLaura.Semestre = 4;

Estudiante estudianteJeronimo = new Estudiante();
estudianteJeronimo.IdPersona = 3;
estudianteJeronimo.IdEstudiante = 3;
estudianteJeronimo.Nombres = "Jeronimo";
estudianteJeronimo.Apellidos = "Aguilar Jimenez";
estudianteJeronimo.CorreoElectronico = "jeroaj5674@uco.net.co";
estudianteJeronimo.Carrera = "Ingenieria en Sistemas";
estudianteJeronimo.Semestre = 6;

listaEstudiantes.Add(estudianteJoseMiguel);
listaEstudiantes.Add(estudianteLaura);
listaEstudiantes.Add(estudianteJeronimo);

// Imprimir todos los estudiantes
Console.WriteLine("=== Lista de todos los estudiantes ===");
foreach (Estudiante estudiante in listaEstudiantes)
{
	Console.WriteLine(estudiante.ObtenerInformacion());
}

// Filtro: estudiantes de Ingenieria en Sistemas
Console.WriteLine("\n=== Estudiantes de Ingenieria en Sistemas ===");
foreach (Estudiante estudiante in listaEstudiantes)
{
	if (estudiante.Carrera == "Ingenieria en Sistemas")
	{
		Console.WriteLine(estudiante.ObtenerInformacion());
	}
}

// -------------------------------------------------------
// Seccion Docentes
// -------------------------------------------------------

List<Docente> listaDocentes = new List<Docente>();

Docente docenteCarlos = new Docente();
docenteCarlos.IdPersona = 4;
docenteCarlos.IdDocente = 1;
docenteCarlos.Nombres = "Carlos";
docenteCarlos.Apellidos = "Mendez Parra";
docenteCarlos.CorreoElectronico = "carlos.mendez@uco.edu.co";
docenteCarlos.Materia = "Programacion Orientada a Objetos";
docenteCarlos.TipoContrato = "Tiempo completo";

Docente docenteCristian = new Docente();
docenteCristian.IdPersona = 5;
docenteCristian.IdDocente = 2;
docenteCristian.Nombres = "Cristian";
docenteCristian.Apellidos = "Posada Vasco";
docenteCristian.CorreoElectronico = "ana.suarez@uco.edu.co";
docenteCristian.Materia = "Calculo Diferencial";
docenteCristian.TipoContrato = "Catedra";

Docente docenteRicardo = new Docente();
docenteRicardo.IdPersona = 6;
docenteRicardo.IdDocente = 3;
docenteRicardo.Nombres = "Ricardo";
docenteRicardo.Apellidos = "Molina Castro";
docenteRicardo.CorreoElectronico = "ricardo.molina@uco.edu.co";
docenteRicardo.Materia = "Programacion Orientada a Objetos";
docenteRicardo.TipoContrato = "Tiempo completo";

listaDocentes.Add(docenteCarlos);
listaDocentes.Add(docenteCristian);
listaDocentes.Add(docenteRicardo);

// Imprimir todos los docentes
Console.WriteLine("\n=== Lista de todos los docentes ===");
foreach (Docente docente in listaDocentes)
{
	Console.WriteLine(docente.ObtenerInformacion());
}

// Filtro: docentes de tiempo completo
Console.WriteLine("\n=== Docentes de tiempo completo ===");
foreach (Docente docente in listaDocentes)
{
	if (docente.TipoContrato == "Tiempo completo")
	{
		Console.WriteLine(docente.ObtenerInformacion());
	}
}

// Filtro: docentes que dictan POO
Console.WriteLine("\n=== Docentes que dictan POO ===");
foreach (Docente docente in listaDocentes)
{
	if (docente.Materia == "Programacion Orientada a Objetos")
	{
		Console.WriteLine(docente.ObtenerInformacion());
	}
}

Console.WriteLine("\nFin del programa.");