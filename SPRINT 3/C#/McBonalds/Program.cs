using System;

namespace McBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente ("Marcos", "+55 11 91234-5678", "marcos@email.com");

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Telefone);
        } 
    }
}
