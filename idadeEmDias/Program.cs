using System;

namespace idadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler a idade e calcule o numero de dias

            const int ANOEMDIAS = 365;
            int idadeDias, idade;
            string nomeUsuario;

            Console.WriteLine(" informe o seu nome");
            nomeUsuario = (Console.ReadLine());

            Console.WriteLine("Infome a sua idade");
            idade = int.Parse(Console.ReadLine());

            idadeDias = idade * ANOEMDIAS;

            Console.WriteLine("Ola {0}!, você viveu {1} dias de vida",nomeUsuario,idadeDias);

        }
    }
}
