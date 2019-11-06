using System;

namespace Triângulos {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("=======================");
            Console.WriteLine ("Formação de Triângulos");
            Console.WriteLine ("=======================");

            Console.WriteLine ("Digite a altura do triãngulo");
            int h = int.Parse (Console.ReadLine ());

            int n = 1;

            for (int i = 0; i < n; i++) {
                string estrelas = "";
                for (int j = 0; j < h; j++) {
                    estrelas += "*";
                    Console.WriteLine (estrelas);
                }
                Console.WriteLine ();
            }
        }
    }
}