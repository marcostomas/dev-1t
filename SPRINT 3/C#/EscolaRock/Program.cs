using System;
using EscolaRock.Models;

namespace EscolaRock {
    enum FormacaoEnum : int {
        TRIO = 3, QUARTETO
    }

    enum InstrumentosEnum : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO
    }

    enum CategoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    }
    class Program {
        static void Main (string[] args) {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames (typeof (CategoriaEnum));

            var opcoesFormacao = new List<string> () {
                "   - 0          ",
                "   - 1          "
            };

            opcaoFomracao = 0;
            string menubar = "====================================";

            do {
                bool formacaoEscolhida = false;
                do {
                    Console.Clear ();
                    System.Console.WriteLine (menubar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.Black;
                    System.Console.WriteLine ("Uélcome");
                    Console.ResetColor ();
                    System.Console.WriteLine (menubar);

                    for (int i = 0; i < opcoesFormacao.Count; i++) {
                        string titulo = TratarTituloMenu (itensMenuPrincipal[i]);

                        if (opcoesFormacao == 1) {
                            DestacarOpcao (opcoesFormacao[opcoesFormacao].Replace (".", ">").Replace (i.ToString (), titulo));
                        } else {
                            System.Console.WriteLine (opcoesFormacao[i].Replace (i.ToString (), titulo));
                        }

                        var key = Console.ReadKey (true).Key;

                        switch (key) {
                            case ConsoleKey.UpArrow:
                                opcoesFormacaoSelecionada = opcaoFomracaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                                break;

                            case ConsoleKey.DownArrow:
                                opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                                break;

                            case ConsoleKey.Enter:
                                formacaoEscolhida = true;
                                break;
                        }
                    }

                    bool bandacompleta = false;
                    int vagas = 0;

                    switch (opcoesFormacaoEscolhida) {
                        case 0:
                            vagas = 2;

                            do {
                                ExibirMenuInstrumento ();
                                System.Console.WriteLine ($"Digite o código do intrumento de harmonia: ");
                                var Instrumento = Deposito.Instrumento[codigo];
                                vagas--;
                                Type interfaceEncontrada = Instrumento.GetType ().GetInterface ("Harmonia");
                                if (interfaceEncontrada != null) {
                                    ColocarNaBanda ((IPercussao) Instrumento);
                                } else {
                                    continue;
                                }
                                System.Console.WriteLine ($"Digite o código do intrumento de música: ");
                                instrumento = Deposito.Instrumento[codigo];
                                vagas--;
                                if (vagas == 0) {
                                    bandacompleta = true;
                                }
                            } while (!bandacompleta)
                            System.Console.WriteLine ("Banda Completa!");
                    }
                }
            }
        }
    }
}