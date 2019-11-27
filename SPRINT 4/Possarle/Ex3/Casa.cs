namespace Ex3
{
    public class Casa
    {
        public Rua Rua;
        public int Numero;
        public int TotalEleitores;

        public Casa (Rua rua, int numero, int totalEleitores )
        {
            this.Rua = rua;
            this.Numero = numero;
            this.TotalEleitores = totalEleitores;
        }
    }
}