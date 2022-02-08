using System;

namespace Ex02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia três valores inteiros e
            //diferentes e mostre-os em ordem decrescente.

            int a, b, c;
            int[] vetor = new int[3];

            Console.WriteLine("Entre com os tres valores: A, B e C: ");
            Console.Write("A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = int.Parse(Console.ReadLine());

            if (b == a)
            {
                while (b == a)
                {
                    Console.WriteLine("o B não pode ser igual ao A !");
                    Console.Write("B: ");
                    b = int.Parse(Console.ReadLine());
                }
        
            }
            Console.Write("C: ");
            c =  int.Parse(Console.ReadLine());
            if (c == a || c == b)
            {
                while (c == a || c == b)
                {
                    Console.WriteLine("o C não pode ser igual ao A nem ao B !");
                    Console.Write("C: ");
                    c = int.Parse(Console.ReadLine());
                }
            }

            vetor[0] = a;
            vetor[1] = b;
            vetor[2] = c;
            int t;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        t = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = t;
                    }
                }
            }
            
            Console.Write("\n" + vetor[0] + " " + vetor[1] + " " + vetor[2]);

            Console.ReadKey();
        }
    }
}
