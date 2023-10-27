using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur lång är låten du vill sätta in?");
        Console.WriteLine("Skriv först minuter");

        int minuter = int.Parse(Console.ReadLine());

        Console.WriteLine("Skriv nu i sekunder");

        int sekunder = int.Parse(Console.ReadLine());

        if ((minuter == 2 && sekunder >= 45) || (minuter > 2 && minuter < 4) || (minuter == 4 && sekunder <= 20))
        {
            Console.WriteLine("Denna låten blir perfekt!");
        }
        else if (minuter < 2 || (minuter == 2 && sekunder < 45))
        {
            Console.WriteLine("Denna låt är tyvärr ej lång nog");
        }
        else if (minuter > 4 || (minuter == 4 && sekunder > 20))
        {
            Console.WriteLine("Denna låt är tyvärr för lång");
        }
        else
        {
            Console.WriteLine("Denna låt ligger inte inom det tillåtna intervallet.");
        }

        Console.ReadKey();
    }
}
