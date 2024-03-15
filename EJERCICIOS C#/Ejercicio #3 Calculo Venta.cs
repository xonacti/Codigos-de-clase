Ejercicio #1

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al programa de calculo de promedio final de ventas");

        
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine();

      
        const int diasDelMes = 30;
        double totalVentas = 0;

      
        for (int dia = 1; dia <= diasDelMes; dia++)
        {
            Console.Write($"Ingrese las ventas del dia {dia}: ");
            double ventasDia;

            while (!double.TryParse(Console.ReadLine(), out ventasDia))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico válido.");
            }

            totalVentas += ventasDia;
        }