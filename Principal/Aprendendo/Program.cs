using System;

namespace Aprendendo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Digite o seu nome e idade");
            a.Nome = Console.ReadLine();
            a.Idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu nome e idade");
            b.Nome = Console.ReadLine();
            b.Idade = byte.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine(a.Nome + " é a pessoa mais velha");
            }

            else
            {
                Console.WriteLine(b.Nome + " é a pessoa mais velha");
            }
        }
    }
}
