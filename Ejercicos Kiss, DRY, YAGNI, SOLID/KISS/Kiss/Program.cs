using System;
using System.Linq;

namespace Kiss{
class Program
{
    static void Main()
    {
        Console.Write("Ingrese los precios de los platos (separados por comas): ");
        string input = Console.ReadLine()!;
        decimal total = input.Split(',').Select(decimal.Parse).Sum();

        Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
        bool personalizada = Console.ReadLine()!.Trim().ToLower() == "s";

        decimal porcentajePropina = personalizada ? ObtenerPropina() : 10;
        decimal totalPagar = total + (total * porcentajePropina / 100);

        Console.WriteLine($"Total a pagar (con propina del {porcentajePropina}%): {totalPagar}");
    }

    static decimal ObtenerPropina()
    {
        Console.Write("Ingrese el porcentaje de propina: ");
        return decimal.Parse(Console.ReadLine()!);
    }
}
}