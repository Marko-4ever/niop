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

        Console.WriteLine(rec1.Remove(3, 5));

        Console.WriteLine(String.Concat(rec1, rec2));

        bool znak = rec1.EndsWith("a");

        if (znak == true)
        {
            Console.WriteLine("Zavrsava s a");
        }
        else
        {
            Console.WriteLine("ne zavrsava s a");
        }

        int result = rec1.CompareTo(rec2);

        if (result == 0)
        {
            Console.WriteLine("Recenica 1 je iste duljine kao recenica 2");
        }
        else
        {
            Console.WriteLine("Recenica 1 nije iste duljine kao recenica 2");
        }
    }
}