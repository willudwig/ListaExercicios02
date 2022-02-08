using System;

namespace Ex01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
            double a, b, c;
            Console.WriteLine("Entre com o valor de A, B e C:\n");
            Console.Write("A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("C: ");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a + b) < c)
            {
                Console.Write("\n");
                Console.WriteLine(a + ", " + b + ", " + c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nA soma de A e B não é menor que C!");
                Console.ReadKey();
                
            }


            
        }
    }
}
