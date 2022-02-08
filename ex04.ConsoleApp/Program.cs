using System;

namespace ex04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: \n");
            int n = Convert.ToInt32(Console.ReadLine());
            if ((n % 2) == 0)
            {
                Console.WriteLine("\nO número é PAR");
                Console.ReadKey();
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine("\nO número é IMPAR");
                Console.ReadKey();
            }
        }
    }
}
