internal class Program
{
    private static void Main(string[] args)
    {
        var rand = new Random();

        int[] elementi = new int[10];
        int max = 0;
        int min = 9999;


        for (int i = 0; i < 10; i++)
        {
            elementi[i] = rand.Next(56);
            //najveci
            if (elementi[i] > max)
            {
                max = elementi[i];
            }
            //najmanji
            if (elementi[i] < min)
            {
                min = elementi[i];
            }
        }

        Console.WriteLine($"Najveci: {max}, najmanji: {min}");

        //ispis parnih i neparnih
        for (int i = 0; i < 10; i++)
        {
            
            if (elementi[i] % 2 == 0)
            {
                Console.WriteLine($"Parni broj: {elementi[i]}");
            }
            else
            {
                Console.WriteLine($"Neparni broj: {elementi[i]}");
            }
        }
    }
}