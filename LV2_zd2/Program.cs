using System;

internal class Program
{
    private static void Main(string[] args)
    {
        float broj1;
        float broj2;
        char odluka = 'n';
        float q = 0;

        Console.WriteLine("C# console kalkulator");

        do
        {
            Console.WriteLine("Unesite prvi broj: ");
            broj1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            broj2 = float.Parse(Console.ReadLine());

        } while (broj1 == 0 || broj2 == 0);

        do
        {
            float broj3;

            Console.WriteLine("Odaberite operaciju: 1-zbrajanje, 2-oduzimanje, 3-mnozenje, 4-dijeljenje");
            int odabir = int.Parse(Console.ReadLine());

            if (odluka == 'n')
            {

                switch (odabir)
                {
                    case 1:
                        q = broj1 + broj2;
                        break;
                    case 2:
                        q = broj1 - broj2;
                        break;
                    case 3:
                        q = broj1 * broj2;
                        break;
                    case 4:
                        q = broj1 / broj2;
                        break;
                }
                Console.WriteLine(q);
            }
            else
            {
                do
                {
                    Console.WriteLine("Koji je dodatni broj?");
                    broj3 = float.Parse(Console.ReadLine());
                } while (broj3 == 0);


                switch (odabir)
                {
                    case 1:
                        q = q + broj3;
                        break;
                    case 2:
                        q = q - broj3;
                        break;
                    case 3:
                        q = q * broj3;
                        break;
                    case 4:
                        q = q / broj3;
                        break;
                }
            }

            Console.WriteLine("Zelite li dodatni broj ili operaciju (d/n)?");
            odluka = char.Parse(Console.ReadLine());
        } while (odluka == 'd');

        Console.WriteLine(q);
    }
}