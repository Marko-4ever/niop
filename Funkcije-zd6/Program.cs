internal class Program
{
    public static void Zbrajanje(int k, int n)
    {
        for (int i = k; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
    private static void Main(string[] args)
    {
        int k, n;

        Console.WriteLine("Unesi prvu granicu:");
        k = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesi krajnju granicu:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");
        Zbrajanje(k, n);
    }
}