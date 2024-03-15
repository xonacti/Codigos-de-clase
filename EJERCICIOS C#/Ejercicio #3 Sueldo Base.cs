using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de sueldo neto para empleados de una empresa de calzado");

      
        Console.Write("Ingrese el sueldo base del empleado: ");
        double sueldoBase;

        while (!double.TryParse(Console.ReadLine(), out sueldoBase) || sueldoBase < 3300)
        {
            Console.WriteLine("Por favor, ingrese un sueldo base válido (mínimo 3300).");
        }

        
        double renta = sueldoBase * 0.10;      // 10% de renta
        double afp = sueldoBase * 0.07;        // 7% de AFP
        double seguroSocial = sueldoBase * 0.05; // 5% de Seguro Social

        double sueldoNeto = sueldoBase - renta - afp - seguroSocial;

        Console.WriteLine("\nResumen de descuentos y sueldo neto:");
        Console.WriteLine($"Sueldo Base: {sueldoBase}");
        Console.WriteLine($"Descuento por Renta (10%): {renta}");
        Console.WriteLine($"Descuento por AFP (7%): {afp}");
        Console.WriteLine($"Descuento por Seguro Social (5%): {seguroSocial}");
        Console.WriteLine($"Sueldo Neto a Pagar: {sueldoNeto}");

        Console.WriteLine("\n¡Gracias por utilizar el programa!");
    }
}