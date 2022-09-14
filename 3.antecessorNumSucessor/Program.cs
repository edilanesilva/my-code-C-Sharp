using System;

namespace antecessorNumSucessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, numAntecessor, numSucessor;
            Console.WriteLine("Informe um numero");
            num = int.Parse(Console.ReadLine());

            numAntecessor = num - 1;
            numSucessor = num + 1;

            Console.WriteLine("O antecessor do numero {0} é {1} e o sucessor {2}",num, numAntecessor, numSucessor);

        }
    }
}
