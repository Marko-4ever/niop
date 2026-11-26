internal class Program
{
    private static void Main(string[] args)
    {
        var rand = new Random();
        List<string> nominirani = new List<string> { "Karim Benzema", "Kevin De Bruyne", "Cristiano Ronaldo", "Erling Haaland", "Jorginho", "N'Golo", "Kante", "Robert Lewandowski", "Kylian Mbappe", "Lionel Messi", "Neymar", "Mohammed Salah" };
        var vrijeme1 = DateTime.Now;
        nominirani.Sort();
        Console.WriteLine($"{vrijeme1} je vrijeme stvaranje liste");
        foreach (var ime in nominirani)
        {
            Console.Write($"{ime} ");
        }

        List<string> finalisti = new List<string> { nominirani[0], nominirani[1], nominirani[2] };
        var vrijeme2 = DateTime.Now;
        Console.WriteLine($"{vrijeme2} je vrijeme biranja finalista");

        Console.WriteLine($"igrac ulice je ");
    }
}