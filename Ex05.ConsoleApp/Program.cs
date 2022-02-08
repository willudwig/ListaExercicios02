using System;

namespace Ex05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores de A e B: \n");

            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
          
            int c;
            if (a == b)
            {
                c = a + b;
                Console.WriteLine("\n" + c);
                Console.ReadKey();
            }
            else
                c = a * b;
                Console.WriteLine("\n" + c);
                Console.ReadKey();
        }
    }
}
