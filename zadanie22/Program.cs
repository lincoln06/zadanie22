using System;
using System.Collections.Generic;

namespace zadanie22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszy produkt");
            List<string> lista = new List<string>();
            string produkt = Console.ReadLine();
            lista.Add(produkt);
            char wybor = 't';
            int lp = 1;
            while(wybor!='n'&&wybor!='N')
            {
                Console.Write("Czy chcesz dodać kolejny produkt? (T/N) ");
                wybor = char.Parse(Console.ReadLine());
                while (wybor == 't' || wybor == 'T')
                {
                    Console.Write("Nazwa:\t");
                    produkt = Console.ReadLine();
                    lista.Add(produkt);
                    Console.Write("Czy chcesz dodać kolejny produkt? (T/N) ");
                    wybor = char.Parse(Console.ReadLine());
                }
            }
            lista.Sort();
            Console.WriteLine("\nTwoja lista zakupów:\n");
            foreach(var e in lista)
            {
                Console.WriteLine($"{lp}\t{e}");
                lp++;
            }
            Console.ReadKey();
        }
    }
}
