using System;

namespace Números
{
     class Program
    {
        static void Main(string[] args)
        { 

            int numero = 0;

            do{
                Console.WriteLine("=========================");
                Console.WriteLine("Este Número É Par ou Ímpar?");
                Console.WriteLine("=========================");

                Console.WriteLine("Informe um Número");
                numero = int.Parse(Console.ReadLine());


                if(numero != 0){

                    if(numero %2 == 0) {
                        Console.WriteLine("Este Número É Par!");
                    }

                    else{
                        Console.WriteLine("Este Número É Ímpar!");
                    }
                
                    Console.WriteLine("Caso Queira Sair do Programa, Aperte (0)");
                }

            }while(numero != 0);

        }

    }
}