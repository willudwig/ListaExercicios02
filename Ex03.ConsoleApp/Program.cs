using System;

namespace Ex03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * A fórmula é IMC = peso / (altura) ²
             * 
             *  e mostre sua condição de acordo com a tabela abaixo. 
             *  
             *  IMC em adultos Condição 
             *  Abaixo de 18,5 Abaixo do peso --
             *  Entre 18,5 e 25 Peso normal --
             *  Entre 25 e 30 Acima do peso --
             *  Acima de 30 obeso
             */

            Console.WriteLine("Entre com peso e altura: ");
            Console.Write("Peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura,2);

            if (imc < 18.5)
            {
                Console.WriteLine("\nAbaixo do peso ideal.");
                Console.ReadKey();
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("\nPeso ideal.");
                Console.ReadKey();
            }
            else if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine("\nAcima do peso ideal.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nObesidade.");
                Console.ReadKey();
            }
        }
    }
}
