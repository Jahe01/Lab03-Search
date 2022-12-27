namespace Lab03_Search;
using System;
using System.Diagnostics;
using System.Globalization;
class BinarySearch
{
    static void Main1(string[] args)
    {
        // la hora de inicio de ejecución
        DateTime startTime = DateTime.Now;
        Console.WriteLine("Hora de inicio de ejecución: {0}", startTime);

        int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60, 34, 65, 76, 88, 99, 90, 12, 23, 43, -54, 67, 76 };

        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine($" A[[{i}]]={A[i]} , ");
        }

        Console.WriteLine("\nIngrese un numero a buscar: ");
        int valorleido = Convert.ToInt32(Console.ReadLine());

        Stopwatch time1 = new Stopwatch();
        time1.Start();

        int posicionEncontrada = busquedaBinaria(A, A.Length, valorleido);
        if (posicionEncontrada != -1)
        {
            Console.WriteLine($"\nElemento encontrado en posicion en A[{posicionEncontrada}]={A[posicionEncontrada]}");
            time1.Stop();
            Console.WriteLine($"  Tiempo: {time1.Elapsed.TotalMilliseconds}ms");
        }
        else
        {
            Console.WriteLine($"Elemento no encontrado");
        }
        // la hora de fin de ejecución
        DateTime endTime = DateTime.Now;
        Console.WriteLine("Hora de fin de ejecución: {0}", endTime);

    }
    static int busquedaBinaria(int[] lista, int n, int clave)
    {

        int bajo = 0, alto = n - 1, central = -1;
        bool encontrado = false;
        while ((bajo <= alto) && (!encontrado))

        {
            central = (bajo + alto) / 2;
            if (lista[central] == clave)
                encontrado = true;
            else if (clave < lista[central])
                alto = central - 1;
            else bajo = central + 1;
        }
        return encontrado ? central : -1;

    }
}
