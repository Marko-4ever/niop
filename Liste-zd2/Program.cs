using System.Collections;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList pojmovi = new ArrayList() { "visok", "kosarku", "je", 'i', "vrlo dobro", 2.03, "Eugen", "igra" };
        ArrayList recenica = new ArrayList();

        recenica.Add(pojmovi[6]);
        recenica.Add(pojmovi[2]);
        recenica.Add(pojmovi[0]);
        recenica.Add(pojmovi[5]);
        recenica.Add(pojmovi[3]);
        recenica.Add(pojmovi[7]);
        recenica.Add(pojmovi[4]);
        recenica.Add(pojmovi[1]);

        foreach (var rijec in recenica)
        {
            Console.Write($"{rijec} ");
        }
    }
}