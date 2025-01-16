class Prueba
{
    static void Main(string[] args)
    {
        // Crear una escuela
        Escuela escuela = new Escuela("Politecnico ITLA");

        // Crear clases
        Clase clase1 = new Clase("5A");
        Clase clase2 = new Clase("5B");

        // Crear estudiantes
        Estudiante estudiante1 = new Estudiante("Juan Pérez", 101);
        Estudiante estudiante2 = new Estudiante("Ana López", 102);

        // Crear profesores
        Profesor profesor1 = new Profesor("Francis Ramirez");
        Profesor profesor2 = new Profesor("Edwin Perez");

        // Crear cursos
        Curso curso1 = new Curso("Matemáticas", 20, 100);
        Curso curso2 = new Curso("Ciencias", 15, 80);

        // Asignar cursos a profesores
        profesor1.AgregarCurso(curso1);
        profesor2.AgregarCurso(curso2);

        // Agregar estudiantes y profesores a las clases
        clase1.AgregarEstudiante(estudiante1);
        clase1.AgregarProfesor(profesor1);

        clase2.AgregarEstudiante(estudiante2);
        clase2.AgregarProfesor(profesor2);

        // Agregar clases a la escuela
        escuela.AgregarClase(clase1);
        escuela.AgregarClase(clase2);

        // Mostrar información de la escuela
        Console.WriteLine($"Escuela: {escuela.Nombre}");
        foreach (var clase in escuela.Clases)
        {
            Console.WriteLine($"Clase: {clase.IdUnico}");
            Console.WriteLine("Estudiantes:");
            foreach (var estudiante in clase.Estudiantes)
            {
                Console.WriteLine($" - {estudiante.Nombre} (#{estudiante.NumeroUnico})");
            }
            Console.WriteLine("Profesores:");
            foreach (var profesor in clase.Profesores)
            {
                Console.WriteLine($" - {profesor.Nombre}");
            }
        }
    }
}