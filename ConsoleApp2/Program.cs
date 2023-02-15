using System;
class Program
{
    static bool PrimtalsUndersökarn(int tal)
    {
        for (int i = tal - 1; 1 < i; i--)
        {
            if (tal % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static int AllaPrimtal(int tal)
    {
        int PrimtalNummer = 0;
        for (; tal > 0; tal--)
        {
            if (PrimtalsUndersökarn(tal))
            {
                PrimtalNummer++;
            }
        }
        return PrimtalNummer;
    }
    static bool avsluta()
    {
        return false;
    }
    static void Meny()
    {
        bool kör = true;
        while (kör)
        {
            Console.WriteLine("Välj ett av alternativen");
            Console.WriteLine("1. Är x ett primtal?");
            Console.WriteLine("2. Hur många nummer >x är primtal");
            Console.WriteLine("3. Avsluta programmet");
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:
                    Console.Write("Skriv ett tal ? ");
                    Console.WriteLine("Är det ett primtal? " + PrimtalsUndersökarn(int.Parse(Console.ReadLine())));
                    break;
                case 2:
                    Console.WriteLine("Skriv ett tal");
                    int tal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Det finns: " + AllaPrimtal(tal) + " primtal mellan 0-" + tal);
                    break;
                case 3:
                    kör = avsluta();
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
    static void Main()
    {
        Meny();

    }
}
