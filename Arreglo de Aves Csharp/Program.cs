using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<string> aves = new List<string> { "Loro gris", "Paloma de diamante", "Coctel" };
        Console.WriteLine("Los valores de la lista antes de insertar:");

       
        foreach (string ave in aves)
        {
            Console.Write(ave + " ");
        }
        Console.WriteLine();

        
        aves.Add("Mayna");
        aves.Add("Periquitos");
        aves.Add("Cacatua");

        Console.WriteLine("Los valores de la lista después de insertar:");

        
        foreach (string ave in aves)
        {
            Console.Write(ave + " ");
        }
        Console.WriteLine();
    }
}
