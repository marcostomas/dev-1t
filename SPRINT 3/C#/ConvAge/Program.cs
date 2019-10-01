using System;

namespace ConvAge {
    class Program {
        static void Main (string[] args) {
            
            int num1 = 0;
            // int num2 = 0;
            // string oper;

            Console.WriteLine ("Console Calculadora de idade em C#\r");
            Console.WriteLine ("========================\n");

            Console.WriteLine ("Insira sua idade");
            num1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Quer converter para qual?");
            Console.WriteLine ("\tm - Meses");
            Console.WriteLine ("\td - Dias");
            Console.WriteLine ("\th - Horas");
            Console.WriteLine ("\tn - Minutos");

            switch (Console.ReadLine ()) {
                case "m":
                    Console.WriteLine ($"Resultado: {num1} * {12} = " + (num1 * 12));
                    break;
                case "d":
                    Console.WriteLine ($"Resultado: {num1} * {365} = " + (num1 * 365));
                    break;
                case "h":
                    Console.WriteLine ($"Resultado: {num1} * {8640} = " + (num1 * 8640));
                    break;
                case "n":
                    Console.WriteLine ($"Resultado: {num1} * {518400} = " + (num1 * 518400));
                    break;

            }

            Console.WriteLine("Aperte qualquer tecla para encerrar o programa");
            Console.ReadKey ();
        }
    }
}