using System;

namespace Vetor {
    class Program {
        static void Main (string[] args) {

            int[] vetor = new int [6];

            for(int cont=0; cont < 6; cont++){
                Console.WriteLine("Digite um número");
                vetor [cont] = int.Parse(Console.ReadLine());
            }

            foreach(int num in vetor){
                
                if(num%2 == 0){
                    pares += 1;
                    
                    // Formas Diferentes de se fazer
                    // pares = pares + 1;
                    // pares++ (só funciona para MAIS 1)
                }

                else{
                    impares++;
                }
            }
        }
    }
}