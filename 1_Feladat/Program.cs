using System;

class Program
{
    static void Main()
    {
        // Bekérjük a karaktert és a sztringet a felhasználótól
        Console.Write("Adj meg egy karaktert: ");
        char karakter = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Új sor a karakter beírása után

        Console.Write("Adj meg egy sztringet: ");
        string sztring = Console.ReadLine();

        // Megkeressük a karaktert a sztringben
        int pozíció = sztring.IndexOf(karakter);

        // Kiírjuk az eredményt
        if (pozíció != -1)
        {
            Console.WriteLine($"A karakter pozíciója: {pozíció}");
        }
        else
        {
            Console.WriteLine("A karakter nem található a sztringben.");
        }
    }
}
