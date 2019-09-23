using System;

namespace Usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string senha = "admin";

            Console.WriteLine("Usuário");
            login = Console.ReadLine();

            Console.WriteLine("Senha");
            senha = Console.ReadLine();

            if ((login == "admin") && (senha == "admin")){
                Console.WriteLine("Olá Alexandre");
            }

            else {
                Console.WriteLine("Fala vagabundo, bem-vindo de volta");
            }
        }
    }
}
