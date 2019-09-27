using System;

namespace ConvAge {
    class Program {
        static void Main (string[] args) {
            
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine ("Console Calculadora de idade em C#\r");
            Console.WriteLine ("========================\n");

            Console.WriteLine ("Insira sua idade");
            num1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Quer converter para qual?");
            Console.WriteLine ("\ta - Meses");
            Console.WriteLine ("\ts - Dias");
            Console.WriteLine ("\tm - Horas");
            Console.WriteLine ("\td - Minutos");

            switch (Console.ReadLine ()) {
                case "a":
                    Console.WriteLine ($"Resultado: {num1} * {12} = " + (num1 * 12));
                    break;
                case "s":
                    Console.WriteLine ($"Resultado: {num1} * {365} = " + (num1 * 365));
                    break;
                case "m":
                    Console.WriteLine ($"Resultado: {num1} * {8640} = " + (num1 * 8640));
                    break;
                case "d":
                    Console.WriteLine ($"Resultado: {num1} * {518400} = " + (num1 * 518400));
                    break;

            }

            Console.Write ("Aperte qualquer tecla para encerrar o programa");
            Console.ReadKey ();
        }
    }
}