using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        var rand = new Random();

        List<string> valerio = new List<string> { "mia", "lorena", "lara", "daria", "doris", "marko", "luka", "ivano", "david" };
        List<string> petar = new List<string> { "ivan", "fran", "dominik", "emerik", "toni", "dejan", "ines" };

        int win = rand.Next(9);
        foreach (var dobitnik in valerio)
        {
            int indeks = valerio.IndexOf(dobitnik);
            if (win == indeks)
            {
                Console.WriteLine($"{dobitnik} dobiva novi mobitel");
            }
        }

        win = rand.Next(7);
        foreach (var dobitnik in petar)
        {
            int indeks = petar.IndexOf(dobitnik);
            if (win == indeks)
            {
                Console.WriteLine($"{dobitnik} dobiva novi mobitel");
            }
        }

        valerio.AddRange("Luka", "Matej");
        petar.AddRange("Ivana", "Vedrana");

        List<string> parovi = new List<string> { };

        win = rand.Next(5);
        foreach (var partner in valerio)
        {
            int indeks = valerio.IndexOf(partner);
            if (indeks == win)
            {
                parovi.Add(partner);
            }
        }
        win = rand.Next(4, 11);
        foreach (var partner in valerio)
        {
            int indeks = valerio.IndexOf(partner);
            if (indeks == win)
            {
                parovi.Add(partner);
            }
        }

        win = rand.Next(6);
        foreach (var partner in petar)
        {
            int indeks = petar.IndexOf(partner);
            if (indeks == win)
            {
                parovi.Add(partner);
            }
        }

        win = rand.Next(5, 9);
        foreach (var partner in petar)
        {
            int indeks = petar.IndexOf(partner);
            if (indeks == win)
            {
                parovi.Add(partner);
            }
        }

        Console.WriteLine($"{parovi[0]} i {parovi[1]} te {parovi[2]} i {parovi[3]} plesu ples");
    }
}