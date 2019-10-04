using System;
using DadosCliente;
using DadosTitular;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {

            /*
                !CADASTRO DE CLENTE
            */

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

            /*
                !ABERTURA DE CONTA
            */

            System.Console.WriteLine ("=============================");
            System.Console.WriteLine ("       ABRA SUA CONTA");
            System.Console.WriteLine ("=============================");

            // System.Console.Write ("Nome Do Titular: ");
            // string titular = Console.ReadLine ();

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

            ContaCorrenteclass contaCorrente = new ContaCorrenteclass (agencia, conta, cliente1 );
            contaCorrente.Saldo = saldo;

            /*
                !DEPÓSITO
            */

            System.Console.WriteLine ("=============================");
            System.Console.WriteLine ("     ByteBank - DEPÓSITO");
            System.Console.WriteLine ("=============================");
            
            Cliente usuario = contaCorrente.Titular;
            System.Console.WriteLine($"Bem-Vindo {usuario.Nome}");
            System.Console.WriteLine($"Agencia: {contaCorrente.Agencia} / Conta: {contaCorrente.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            System.Console.WriteLine("Digite o valor do depósito: R$ ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente.Deposito(valor);
            System.Console.WriteLine();

            /* 
                !SAQUE
            */

            System.Console.WriteLine ("=============================");
            System.Console.WriteLine ("       ByteBank - SAQUE");
            System.Console.WriteLine ("=============================");

            System.Console.WriteLine($"Bem-Vindo {usuario.Nome}");
            System.Console.WriteLine($"Agência {contaCorrente.Agencia}");
            System.Console.WriteLine($"Saldo: R$ {contaCorrente.Saldo}");
            System.Console.WriteLine("Valor de saque: R$ ");
            double saque =double.Parse(Console.ReadLine());
            if(contaCorrente.Saque(valor)){
                System.Console.WriteLine("Retire as Notas Abaixo");
            }else{
                System.Console.WriteLine("Operação Não Realizada [erro 00001]");
            }
            System.Console.WriteLine($"Saldo Altual: R$ {contaCorrente.Saldo}");
            
            /*
            !TRASFERÊNCIA
            */

            Cliente cliente2 = new Cliente("Marcos","546.789.123-00","m@t.com");
            ContaCorrenteclass contaCorrente2 = new ContaCorrenteclass("1111","2222",cliente2);
            System.Console.WriteLine ("=============================");
            System.Console.WriteLine ("  ByteBank - TRANSFRÊNCIA");
            System.Console.WriteLine ("=============================");
            System.Console.WriteLine($"Bem-Vindo {usuario.Nome}");
            System.Console.WriteLine($"Agência {contaCorrente.Agencia}");
            System.Console.WriteLine($"Saldo Origem: R$ {contaCorrente.Saldo}");
            System.Console.WriteLine($"Saldo Destino: R$ {contaCorrente2.Saldo}");
            System.Console.WriteLine("Valor à ser transferido: R$ ");
            valor = double.Parse(Console.ReadLine());

            if(contaCorrente.Transferencia(contaCorrente2,valor)){
                System.Console.WriteLine("Transferência Efetuada");
            }else{
                System.Console.WriteLine("Operação Não Realizada [erro 01212]");
            }

        }
    }
}
