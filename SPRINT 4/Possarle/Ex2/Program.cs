using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 0;
            Console.WriteLine("Valor do Item:");
            
            System.Console.WriteLine("Digite o valor do custo de aquisição do produto:");
            double vAquisicao = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o volume ocupado (M3):");
            double tamanho = double.Parse(Console.ReadLine());

            preco = vAquisicao + tamanho;

            System.Console.WriteLine("Precisa de refrigerador? s/n ");
            string refrigerado = Console.ReadLine();

            if(refrigerado == "s")
            {
                preco = preco * 1.5;
            }

            System.Console.WriteLine("Prazo da Validade em dias:");
            uint validade = uint.Parse(Console.ReadLine());

            if(validade <= 30)
            {
                preco = preco - (30/100);
            }

            System.Console.WriteLine($"O Valor do produto é de R$ {preco}");
        }
    }
}
