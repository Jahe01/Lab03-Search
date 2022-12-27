namespace Lab03_Search;
using System;
using System.Globalization;

class SequentialSearch
{
    static void Main(string[] args)
    {
        // la hora de inicio de ejecución
        DateTime startTime = DateTime.Now;
        Console.WriteLine("Hora de inicio de ejecución: {0}", startTime);

        // Crear 100 enteros aleatorios
        Random random = new Random();
        int[] numeros = new int[100];
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(1, 201);//numeros random del 1 al 200
        }

        int exito = 0;
        int fallas = 0;
        for (int i = 0; i < 50; i++)
        {
            int busqnum = random.Next(1, 201);
            bool encontr = false;
            for (int j = 0; j < numeros.Length; j++)
            {
                if (numeros[j] == busqnum)
                {
                    encontr = true;
                    break;
                }
            }
            if (encontr)
            {
                exito++;
            }
            else
            {
                fallas++;
            }
        }

        //  estadísticas
        Console.WriteLine("Número de búsquedas con éxito: {0}", exito);
        Console.WriteLine("Número de búsquedas fallidas: {0}", fallas);
        Console.WriteLine("Porcentaje de éxito de búsquedas: {0:P2}", (double)exito / 50);
        Console.WriteLine("Porcentaje de fallo de búsquedas: {0:P2}", (double)fallas / 50);

        Console.WriteLine("Números en orden creciente:");
        foreach (int number in numeros.OrderBy(x => x))
        {
            Console.Write(number + " ");
        }

        // la hora de fin de ejecución
        DateTime endTime = DateTime.Now;
        Console.WriteLine("\nHora de fin de ejecución: {0}", endTime);

    }
}
