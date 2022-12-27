namespace Lab03_Search;
using System;
using System.Diagnostics;
using System.Globalization;

class LinealSearch
{
 static void Main2(string[] args)
    {

        // la hora de inicio de ejecución
        DateTime startTime = DateTime.Now;

        Console.WriteLine("Hora de inicio de ejecución: {0}", startTime);
        Console.WriteLine("Algoritmo de busqueda lineal ");
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 88, 12, 25, 13, 45, 67, 78, 98 };
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine($" A[[{i}]]={A[i]}, ");
        }
        Console.WriteLine("\nIngrese un numero a buscar: ");
        int valorleido = Convert.ToInt32(Console.ReadLine());

        
        //Cronómetro
        Stopwatch time1 = new Stopwatch();
        time1.Start();//inicio del cronómetro

        int posicionEncontrada = BusquedaLinealID(A, A.Length, valorleido);
       
        if (posicionEncontrada != -1)
        {
            time1.Stop();//fin del cronómetro
            Console.WriteLine($"\nElemento encontrado en posicion en A[{posicionEncontrada}]={A[posicionEncontrada]}");
            Console.WriteLine($"  Tiempo: {time1.Elapsed.TotalMilliseconds}ms");
        }
        else
        {
            Console.WriteLine($"Elemento no encontrado");
        }

        //la hora de fin de ejecución
        DateTime endTime = DateTime.Now;
        Console.WriteLine("Hora de fin de ejecución: {0}", endTime);
    }
    static int BusquedaLinealID(int[] A, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++)
        {
            if (A[i] == clave)
                return i;
        }
        return -1;
    }

}
