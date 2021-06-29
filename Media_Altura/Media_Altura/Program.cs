using System;

namespace Media_Altura {
    class Program {
        static void Main(string[] args) {
            double sum = 0;
            double media = 0;

            Console.WriteLine("Quantas pessoas serão medidas? ");
            int n = int.Parse(Console.ReadLine());
            Pessoa[] quantidade_pessoa = new Pessoa[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite a altura de cada pessoa: ");
                quantidade_pessoa[i] = new Pessoa(double.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < n; i++) {
                sum += quantidade_pessoa[i].Altura;
            }
            media = sum / n;
            Console.WriteLine("A média é:" + media);
        }
    }
}
