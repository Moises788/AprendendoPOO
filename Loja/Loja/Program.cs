using System;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Entre com os dados do produto");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("quanto quer adicionar?" );
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("quanto quer subtrair?");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
