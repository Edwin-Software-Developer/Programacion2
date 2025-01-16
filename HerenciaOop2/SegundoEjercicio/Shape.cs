/*2.  Defina una clase abstracta Shape con el método abstracto CalculateSurface() y el ancho y alto de los campos. 
Defina dos clases adicionales para un triangle y un rectangle, que implementan CalculateSurface(). 
Este método tiene que devolver las áreas del rectángulo (alto*ancho) y del triángulo (alto*ancho/2).  
Defina una clase para un Circle con un constructor apropiado, que inicialice los dos campos (alto y ancho) con el mismo 
valor (el radio) e implemente el método abstracto para calcular el área. Crea una matriz de diferentes Shapes y calcula el
área de cada forma en otra matriz.*/


using System;
using System.Collections.Generic;

public abstract class Shape
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Shape(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public abstract double CalculateSurface();
}