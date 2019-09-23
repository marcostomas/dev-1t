using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("==================================");
            // Console.WriteLine("Deseja Obter a Tabuada do 1 ao 10?");
            // Console.WriteLine("==================================");
            // (Console.ReadLine());

            for(int i=1;i<=10;i++){
                for(int j=1; j<=10; j++){
                    Console.Write($"{j,-2} * {i,-2} = {j*i,-3}");
                }
                Console.WriteLine();
            }
        }
    }
}
