using System;

namespace _4.areaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaCirculo, raioCirculo;
            Console.WriteLine("Informe o raio do circulo");
            raioCirculo = double.Parse(Console.ReadLine());

            areaCirculo = Math.PI * Math.Pow(raioCirculo, 2);

            Console.WriteLine("A área do circulo de raio {0} é: {1}",raioCirculo, areaCirculo);



        }
    }
}
