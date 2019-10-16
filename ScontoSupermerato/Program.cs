using System;

namespace ScontoSupermerato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quale è stato l'importo della spesa?");
            double spesa = double.Parse(Console.ReadLine());
            if (spesa >= 100)
            {
                double percentuale = (spesa * 20) / 100;
                double finale = spesa - percentuale;
                Console.WriteLine($"L'importo finale è {finale:c}");
            }
            else
            {
                Console.WriteLine("la spesa non supera i 100 euro");
            }
            Console.ReadLine();
        }
    }
}
