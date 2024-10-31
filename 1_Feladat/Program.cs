using System;


class Program
{
    static void Main()
    {

        Console.Write("Adj meg egy karaktert: ");
        char karakter = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Adj meg egy szoveg: ");
        string szoveg = Console.ReadLine();


        int pos = szoveg.IndexOf(karakter);


        if (pos != -1)
        {
            Console.WriteLine($"A karakter pozicioja: {pos}");
        }
        else
        {
            Console.WriteLine("A karakter nem talalhato a szovegben.");
        }
    }
}
