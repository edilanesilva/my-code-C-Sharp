using System;

namespace _7.ordemCrrescente
{
    class Program
    {
        static void Main(string[] args)
        {   
            int num1, num2;
            Console.WriteLine("digite o primeiro numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine($"ordem crescente {num1},{num2}");

            }else
            {
                 Console.WriteLine($"ordem crescente {num2},{num1}");
            }

        }
    }
}
