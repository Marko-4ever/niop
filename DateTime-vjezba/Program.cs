internal class Program
{
    private static void Main(string[] args)
    {
        //prvi dio
        int min, sek, dan;

        min = DateTime.Now.Minute;
        sek = DateTime.Now.Second;
        dan = DateTime.Now.Day;

        Console.WriteLine($"Trenutno je {min} minuta, {sek} sekundi i danas je {dan} u mjesecu.");

        //drugi dio
        DateTime datumIvrijeme = DateTime.Now;

        Console.WriteLine($"Danas je {datumIvrijeme.Year}. godina.");

        DateTime datumrodenja = new DateTime(2009, 10, 25);

        Console.WriteLine($"Imam {(datumIvrijeme.Year - datumrodenja.Year) - 1} godina.");
    }
}