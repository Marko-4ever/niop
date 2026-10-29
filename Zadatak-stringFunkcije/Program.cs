using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string rec1 = "";
        string rec2 = "";

        Console.WriteLine("Unesi prvu recenicu:");
        rec1 = Console.ReadLine();

        Console.WriteLine("Unesi drugu recenicu:");
        rec2 = Console.ReadLine();

        //Console.WriteLine(rec1.Remove(3, 5));

        //Console.WriteLine(String.Concat(rec1, rec2));

        /*bool znak = rec1.EndsWith("a");

        if (znak == true)
        {
            Console.WriteLine("Zavrsava s a");
        }
        else
        {
            Console.WriteLine("ne zavrsava s a");
        }
        */

        //Console.WriteLine($"A se pojavljuje na indeksu {rec1.IndexOf('a')}");

        //rec1 = rec1.Insert(5, "trinaest ");

        //Console.WriteLine($"Prva recenica ima duljinu {rec1.Length}");

        //rec1 = rec1.Replace("imam", "nemam");

        /*string[] recenica = rec1.Split(' ');

        foreach (var rijec in recenica)
        {
            Console.WriteLine(rijec);
        }
        */

        /*if (rec1.StartsWith('t'))
        {
            Console.WriteLine("recenica pocinje sa T");
        }
        else
        {
            Console.WriteLine("Recenica ne pocinje sa T");
        }
        */

        /*string rec3 = rec1.Substring(5);
        Console.WriteLine(rec3);
        */

        /*Console.WriteLine(rec1.ToUpper());
        Console.WriteLine(rec1.ToLower());*/

        //Console.WriteLine(rec1.Trim());
    }
}