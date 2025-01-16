public class Rectangle : Shape
{
    public Rectangle(double ancho, double alto) : base(ancho, alto) { }

    public override double CalculateSurface()
    {
        return Ancho * Alto;
    }
}