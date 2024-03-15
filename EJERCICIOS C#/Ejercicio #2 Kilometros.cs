using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Conversor de distancias: kilómetros a metros, yardas y varas");

        
        Console.Write("Ingrese la cantidad en kilometros: ");
        double kilometros;

        while (!double.TryParse(Console.ReadLine(), out kilometros) || kilometros < 0)
        {
            Console.WriteLine("Por favor, ingrese una cantidad válida de kilometros (mayor o igual a 0).");
        }


        double metros = kilometros * 1000;                    // 1 kilómetro = 1000 metros
        double yardas = metros / 1.09361;                     // 1 metro = 1.09361 yardas
        double varas = metros / 1.1963;                       // 1 metro = 1.1963 varas


        Console.WriteLine($"\nResultados para {kilometros} kilometros:");
        Console.WriteLine($"En metros: {metros} metros");
        Console.WriteLine($"En yardas: {yardas} yardas");
        Console.WriteLine($"En varas: {varas} varas");

        Console.WriteLine("\n¡Gracias por utilizar el programa!");
    }
}