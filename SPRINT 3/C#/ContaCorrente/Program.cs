using System;
using DadosTitular;

namespace ContaCorrente {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("=============================");
            System.Console.WriteLine ("       ABRA SUA CONTA");
            System.Console.WriteLine ("=============================");

            System.Console.Write ("Nome Do Titular: ");
            string titular = Console.ReadLine ();

            System.Console.Write ("Número da Agência: ");
            string agencia = int.Parse(Console.ReadLine ());

            System.Console.Write ("Número da Conta: ");
            string numero = Console.ReadLine ();

            DadosTitular.ContaCorrente cliente1 = new DadosTitular.ContaCorrente(titular, agencia, numero);

            bool saldoOk = false;

            do {
                System.Console.WriteLine ("Saldo");
                string saldo = Console.ReadLine ();
                saldoOk = cliente1.SaldoDif (saldo);

                if (!saldoOk) {
                    System.Console.WriteLine ("Senha Não Atende Aos Requisitos");
                } else {
                    System.Console.WriteLine ("Senha Trocada Com Sucesso");
                }

            } while (!saldoOk);

        }
    }
}