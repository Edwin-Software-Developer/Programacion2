public class Program
{
    public static void Main()
    {
        // Crear una lista de formas
        List<Shape> formas = new List<Shape>
        {
            new Rectangle(5, 10),
            new Triangle(6, 8),
            new Circle(7)
        };

        // Calcular y mostrar el área de cada forma
        foreach (var forma in formas)
        {
            Console.WriteLine($"El área de la forma es: {forma.CalculateSurface():F2}");
        }
    }
}