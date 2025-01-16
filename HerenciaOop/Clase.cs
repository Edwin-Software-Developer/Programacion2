public class Clase
{
    public string IdUnico { get; set; }
    public List<Estudiante> Estudiantes { get; private set; }
    public List<Profesor> Profesores { get; private set; }

    public Clase(string idUnico)
    {
        IdUnico = idUnico;
        Estudiantes = new List<Estudiante>();
        Profesores = new List<Profesor>();
    }

    public void AgregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
    }

    public void AgregarProfesor(Profesor profesor)
    {
        Profesores.Add(profesor);
    }
}