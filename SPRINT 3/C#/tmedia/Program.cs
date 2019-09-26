using System;

namespace tmedia {
    class Program {
        static void Main (string[] args) {
            double maior = 0;
            double menor = 0;

            double[] temperaturas = new double[12];

            for (int i = 0; i < 12; i++) {
                Console.WriteLine ($"Digite a temperatura do mês {i+1}:");
                temperaturas[i] = double.Parse (Console.ReadLine ());
            }

            maior = temperaturas[0];
            menor = temperaturas[0];

            foreach (double temp in temperaturas) {

                if (temp > maior) {
                    maior = temp;
                } else if (temp < menor) {
                    menor = temp;
                }
            }

            Console.WriteLine ($"A maior Temperatura deste ano foi: {maior}°C");

            Console.WriteLine ($"A menor Temperatura deste ano foi: {menor}°C");
        }
    }
}