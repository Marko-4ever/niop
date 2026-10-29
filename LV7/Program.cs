internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Unesi pocetak i zavrsetak u obliku: dd.MM.yyyy. HH:mm");
        DateTime poc = DateTime.Parse(Console.ReadLine());
        DateTime zavrs = DateTime.Parse(Console.ReadLine());

        int razlika = int.Parse(zavrs - poc);

        if (razlika < 0)
        {

        }
    }
}