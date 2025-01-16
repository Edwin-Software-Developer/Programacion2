public class Escuela
{
    public string Nombre { get; set; }
    public List<Clase> Clases { get; private set; }

    public Escuela(string nombre)
    {
        Nombre = nombre;
        Clases = new List<Clase>();
    }

    public void AgregarClase(Clase clase)
    {
        Clases.Add(clase);
    }
}