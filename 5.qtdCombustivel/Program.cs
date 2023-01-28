using System;

namespace _5.qtdCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sabendo que um automovel faz 12km/l, desenvolva um programa C# que informe uma distância e que retorne a quantidade de litros de combustível necessária para percorrê-la.
            
            const int KmL = 12;
            float distancia, qtdLitroCombustivel;
            Console.WriteLine(" informe a distancia a ser percorrida");
            distancia = float.Parse(Console.ReadLine());

            qtdLitroCombustivel = distancia / KmL;

            Console.WriteLine($"A quantidade de combustível necessário para percorrer {distancia} km é de: {qtdLitroCombustivel} L ");
        }
    }
}
