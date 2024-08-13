using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números pares del 1 al 100:");

        // Bucle for para iterar desde 1 hasta 100
        for (int i = 1; i <= 100; i++)
        {
            // Verificamos si el número es par
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Esperar a que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}