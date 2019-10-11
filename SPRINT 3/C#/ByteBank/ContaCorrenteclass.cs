using System;

namespace DadosTitular {
    public class ContaCorrenteclass {

        public DadosCliente.Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double Saldo { get; set; }

        public double saldo {
            get {return Saldo; }
        }

        public ContaCorrenteclass (int Agencia, int Numero, DadosCliente.Cliente Titular) {

            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0;
        }
        public double Deposito (double valor) {
            this.Saldo += valor;
            return this.saldo;
        }
        public bool Saque (double valor) {
            if (valor <= this.saldo) {
                this.Saldo -= valor;
                return true;
            } else {
                return false;
            }
        }
        public bool Transferencia (ContaCorrenteclass destino, double valor) {
            if (Saque (valor)) {
                destino.Deposito (valor);
                return true;
            } else {
                return false;
            }
        }
    }
}