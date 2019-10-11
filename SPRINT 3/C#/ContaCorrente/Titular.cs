using System;

namespace DadosTitular {
public class ContaCorrente {

        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

    public ContaCorrente (int Agencia, int Numero, string Titular) {

            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;

            public bool SaldoDif (double saldo) {
            if (saldo == 0) {
                this.Saldo = saldo;
                return true;
            } else {
                return false;
            }
        }
    }

}