using System;
using DadosCliente;
using DadosTitular;

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

            bool senhaOk = false;
            
            do {
                System.Console.WriteLine ("Digite a Senha");
                string senha = Console.ReadLine ();
                senhaOk = cliente1.TrocaSenha (senha);

                if (!senhaOk) {
                    System.Console.WriteLine ("Senha Não Atende Aos Requisitos");
                } else {
                    System.Console.WriteLine ("Senha Trocada Com Sucesso");
                }

            } while (!senhaOk);

            System.Console.WriteLine ("=============================");
            System.Console.WriteLine ("       ABRA SUA CONTA");
            System.Console.WriteLine ("=============================");

            System.Console.Write ("Nome Do Titular: ");
            string titular = Console.ReadLine ();

            System.Console.WriteLine ();

            System.Console.Write ("Número da Agência: ");
            int agencia = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ();

            System.Console.Write ("Número da Conta: ");
            int conta = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ();

            bool saldoOk = false;
            double saldo;

            do {
                System.Console.WriteLine ("Saldo");
                saldo = double.Parse (Console.ReadLine ());

                if (saldo > 0) {
                    saldoOk = true;
                } else {
                    System.Console.WriteLine ("O Seu Saldo Não Pode ser diferente de R$ 0,00");
                }
            } while (!saldoOk);

            ContaCorrenteclass contaCorrente = new ContaCorrenteclass (agencia, conta, titular);
            contaCorrente.Saldo = saldo;
        }
    }
}
