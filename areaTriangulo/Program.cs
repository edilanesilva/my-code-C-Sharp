using System;

namespace areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agoritmo que calcula a área do triangulo com os dados informado pelo usuario

            int baseTriangulo, alturaTriangulo;
            float areaTriangulo;

            Console.WriteLine("infome a base do tringulo");
            baseTriangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("infome a altura do tringulo");
            alturaTriangulo = int.Parse(Console.ReadLine());

            areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine("A area do triangulo calculado foi de {0} cm²", areaTriangulo);
            



        }
    }
}
