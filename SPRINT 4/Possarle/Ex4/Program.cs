using System;

namespace Ex4 {
    class Program {
        static void Main (string[] args) {
            //! Exercício 4-A

            /*
            Sim, é. Quando são excessões mais derivadas, deve-se colocar métodos, para que, se possível, esses métodos lidem mais à frente com estes erros, ao invés de usar catch.
            */

            //! Exerccício 4-B

            /*
            O bloco try/catch envolve um código, que pode gerar erros, indentificando-o(s) e tratando-o(s), ou seja, lançando uma mensagem ao usuário dizendo que a exceção foi tratada 
            */

            //! Exercício 4-C

            /*
            Quando o método não pode concluir sua funcionalidade definida[1],
            Quando é feita uma chamada inadequada a um objeto, com base no estado do objeto [2], 
            Quando um argumento para um método causa uma exceção [3], 
            */

            //! Exemplos

            /*

            ![1]
            static void CopyObject(SampleClass original)
            {
                if (original == null)
                {
                    throw new System.ArgumentException("Parameter cannot be null", "original");
                }
            }

            ![2]
            class ProgramLog
            {
                System.IO.FileStream logFile = null;
                void OpenLog(System.IO.FileInfo fileName, System.IO.FileMode mode) {}

                void WriteLog()
                {
                    if (!this.logFile.CanWrite)
                    {
                        throw new System.InvalidOperationException("Logfile cannot be read-only");
                    }
                }
            }

            ![3]
            static int GetValueFromArray(int[] array, int index)
            {
                try
                {
                    return array[index];
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
                    throw argEx;
                }
            }
            */
        }
    }
}