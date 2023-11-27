using System;

namespace uppgift_5._3_C_A
{
    class program
    {
        static void Main(string[] args)
        {
            string[] frågor = { "Vad heter Ernst", "Vad heter Johan", "Vad heter Zache", "Vad heter Alexander" };
            string[] rättsvar = { "ernst", "johan", "zache", "alexander" };
            Console.WriteLine("Skriv ett tal 1-4");
            int val = int.Parse(Console.ReadLine());
            Console.WriteLine(frågor[val-1]);
            string svar = Console.ReadLine();
            if (svar.ToLower() == rättsvar[val-1])
            {
                Console.WriteLine("Du svarade rätt!");
            }
            else
            {
                Console.WriteLine("Du svarade fel");
            }
        }
    }
}
