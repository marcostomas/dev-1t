using System;

namespace Formas {
    class Program {
        static void Main (string[] args) {

            double resultado = 0;
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            float num4 = 0;
            float resultado1 = 0;
            string resposta;
            float num5 =;

            Console.WriteLine ("==================");
            Console.WriteLine ("1 - Quadrado");
            Console.WriteLine ("2 - Triângulo");
            Console.WriteLine ("3 - Círculo");
            Console.WriteLine ("4 - Trapézio");
            Console.WriteLine ("5 - Retângulo");
            Console.WriteLine ("6 - Losango");
            Console.WriteLine ("==================");

            Console.WriteLine ("Dê o 1º Valor a ser calculado");
            num1 = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Dê o 2º Valor a ser calculado");
            num2 = double.Parse (Console.ReadLine ());

            resultado = Console.WriteLine();

            switch (resposta) {

                case "1 - Quadrado":
                    Console.WriteLine ("Quadrado");

                    Console.WriteLine ("Dê valor do 1º lado");
                    num1 = double.Parse (Console.ReadLine ());

                    Console.WriteLine ("Dê o valor do 2º lado");
                    num2 = double.Parse (Console.ReadLine ());

                    resultado = num1 * num2;
                    break;

                case "2 - Triângulo":
                    Console.WriteLine ("Triângulo");

                    Console.WriteLine ("Dê valor da Base");
                    num1 = double.Parse (Console.ReadLine ());

                    Console.WriteLine ("Dê o valor da Altura");
                    num2 = double.Parse (Console.ReadLine ());

                    resultado = (num1 * num2) / 2;
                    break;

                case "3 - Círuclo":
                    Console.WriteLine ("Círculo");

                    Console.WriteLine ("Dê valor do Raio");
                    num4 = float.Parse (Console.ReadLine ());

                    resultado1 = (3.14 * num4);
                    break;

                case "4 - Trapézio":
                    Console.WriteLine ("Trapézio");

                    Console.WriteLine ("Dê valor da Base Maior");
                    num1 = double.Parse (Console.ReadLine ());

                    Console.WriteLine ("Dê valor da Base Menor");
                    num2 = double.Parse (Console.ReadLine ());

                    Console.WriteLine ("Dê valor da Altura");
                    num3 = double.Parse (Console.ReadLine ());

                    resultado = (num1 + num2) * num3 / 2;
                    break;

                case "5 - Retângulo":
                    Console.WriteLine ("Retângulo");

                    Console.WriteLine ("Dê valor do 1º lado");
                    num1 = double.Parse (Console.ReadLine ());

                    Console.WriteLine ("Dê o valor do 2º lado");
                    num2 = double.Parse (Console.ReadLine ());
                    
                    resultado = num1 * num2;
                    break;

                case "6 - Losango":
                    Console.WriteLine ("Losângulo");

                    Console.WriteLine ("Dê valor da Diagonal Maior");
                    num1 = double.Parse (Console.ReadLine ());

                    Console.WriteLine ("Dê o valor da Diagonal Menor");
                    num2 = double.Parse (Console.ReadLine ());
                    
                    resultado = (num1 * num2) / 2;
                    break;
            }
        }
    }
}