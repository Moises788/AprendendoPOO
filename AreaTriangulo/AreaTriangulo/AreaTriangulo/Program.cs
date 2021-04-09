using System;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x;
            x = new Triangulo();

            Console.WriteLine("Indique os lados do triângulo x");
            x.L1 = double.Parse(Console.ReadLine());
            x.L2 = double.Parse(Console.ReadLine());
            x.L3 = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do triângulo x é: " + x.Area());
        }
    }
}
