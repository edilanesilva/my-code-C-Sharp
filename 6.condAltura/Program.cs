using System;

namespace _6.condAltura
{
    class Program
    {
        static void Main(string[] args)
        {   
            float altura;
            
            Console.WriteLine("Infome sua altura");
            altura = float.Parse(Console.ReadLine());
           

            if (altura >= 1.80f )
            {
                Console.WriteLine("Alto {0}",altura);
            }
            else
            {
                Console.WriteLine("Baixo");
            }

        }
    }
}
