using System;
using DadosCliente;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("=============================");
            System.Console.WriteLine ("        CADASTRE-SE");
            System.Console.WriteLine ("=============================");

            System.Console.Write ("Nome Completo: ");
            string nome = Console.ReadLine ();

            System.Console.Write ("CPF: ");
            string cpf = Console.ReadLine ();

            System.Console.Write ("E-mail: ");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            do {
                System.Console.WriteLine ("Digite a Senha");
                string senha = Console.ReadLine ();
                bool senhaOk = cliente1.TrocaSenha (senha);
                if (!senhaOk) {
                    System.Console.WriteLine ("Senha Não Atende Aos Requisitos");
                } else {
                    System.Console.WriteLine ("Senha Trocada Com Sucesso");
                }
            } while (!senhaOk);

        }
    }
}