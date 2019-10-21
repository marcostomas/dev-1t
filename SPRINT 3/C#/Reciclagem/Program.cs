using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem {
    enum LixosEnum : uint {
        GARRAFA,
        GARRAFAPET,
        GAURDACHUVA,
        LATINHA,
        PAPELAO,
        POTEMANTEIGA
    }

    enum CategoriaEnum : uint {
        INDEFINIDO,
        METAL,
        ORGÂNICO,
        PAPEL,
        PLÁSTICO,
        VIDRO

    }

    class Program {
        static void Main (string[] args) {
            // /* 
            //     ! MENU
            // */

            // bool querSair = false;
            // string[] itensMenuPrincipal = Enum.GetNames(typeof(LixosEnum));
            // string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            // //  var opcoesFormacao = new List<string>() {
            // //     "    - 0                         ",
            // //     "    - 1                     "
            // // };

            // int opcaoSelecionada = 0;

            // string BarraMenu = "===================================";

            System.Console.WriteLine ("Selecione, das opções abaixo: ");

            do {
                Console.Clear ();
                System.Console.WriteLine ("Selecione os lixos abaixo:");
                System.Console.WriteLine ();
                System.Console.WriteLine ();
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {

                    case 1:
                        System.Console.WriteLine ("Garrafa de Vidro");

                        switch (opcao2) {
                            Console.Clear ();
                            System.Console.WriteLine ("Agora Selecione a lixeira adequada:");
                            Console.Write ("Lixeira: ");

                            case 1:
                                System.Console.WriteLine ("Amarela");
                                break;

                            case 2:
                                System.Console.WriteLine ("Verde");
                                break;

                            case 3:
                                System.Console.WriteLine ("Azul");
                                break;

                            case 4:
                                System.Console.WriteLine ("Vermelha");
                                break;

                            case 5:
                                System.Console.WriteLine ("Marrom");
                                break;

                            case 6:
                                System.Console.WriteLine ("Cinza");
                                break;

                            default:
                                System.Console.WriteLine ("Lixeira Errada");
                                break;
                        }
                        break;

                    case 2:
                        System.Console.WriteLine ("GarrafaPET");

                        switch (opcao2) {
                            Console.Clear ();
                            System.Console.WriteLine ("Agora Selecione a lixeira adequada:");
                            Console.Write ("Lixeira: ");

                            case 1:
                                System.Console.WriteLine ("Amarela");
                                break;

                            case 2:
                                System.Console.WriteLine ("Verde");
                                break;

                            case 3:
                                System.Console.WriteLine ("Azul");
                                break;

                            case 4:
                                System.Console.WriteLine ("Vermelha");
                                break;

                            case 5:
                                System.Console.WriteLine ("Marrom");
                                break;

                            case 6:
                                System.Console.WriteLine ("Cinza");
                                break;

                            default:
                                System.Console.WriteLine ("Lixeira Errada");
                                break;
                        }
                        break;

                    case 3:
                        System.Console.WriteLine ("Guarda Chuva");

                        switch (opcao2) {
                            Console.Clear ();
                            System.Console.WriteLine ("Agora Selecione a lixeira adequada:");
                            Console.Write ("Lixeira: ");

                            case 1:
                                System.Console.WriteLine ("Amarela");
                                break;

                            case 2:
                                System.Console.WriteLine ("Verde");
                                break;

                            case 3:
                                System.Console.WriteLine ("Azul");
                                break;

                            case 4:
                                System.Console.WriteLine ("Vermelha");
                                break;

                            case 5:
                                System.Console.WriteLine ("Marrom");
                                break;

                            case 6:
                                System.Console.WriteLine ("Cinza");
                                break;

                            default:
                                System.Console.WriteLine ("Lixeira Errada");
                                break;
                        }
                        break;

                    case 4:
                        System.Console.WriteLine ("Latinha");

                        switch (opcao2) {
                            Console.Clear ();
                            System.Console.WriteLine ("Agora Selecione a lixeira adequada:");
                            Console.Write ("Lixeira: ");

                            case 1:
                                System.Console.WriteLine ("Amarela");
                                break;

                            case 2:
                                System.Console.WriteLine ("Verde");
                                break;

                            case 3:
                                System.Console.WriteLine ("Azul");
                                break;

                            case 4:
                                System.Console.WriteLine ("Vermelha");
                                break;

                            case 5:
                                System.Console.WriteLine ("Marrom");
                                break;

                            case 6:
                                System.Console.WriteLine ("Cinza");
                                break;

                            default:
                                System.Console.WriteLine ("Lixeira Errada");
                                break;
                        }
                        break;

                    case 5:
                        System.Console.WriteLine ("Papelão");

                        switch (opcao2) {
                            Console.Clear ();
                            System.Console.WriteLine ("Agora Selecione a lixeira adequada:");
                            Console.Write ("Lixeira: ");

                            case 1:
                                System.Console.WriteLine ("Amarela");
                                break;

                            case 2:
                                System.Console.WriteLine ("Verde");
                                break;

                            case 3:
                                System.Console.WriteLine ("Azul");
                                break;

                            case 4:
                                System.Console.WriteLine ("Vermelha");
                                break;

                            case 5:
                                System.Console.WriteLine ("Marrom");
                                break;

                            case 6:
                                System.Console.WriteLine ("Cinza");
                                break;

                            default:
                                System.Console.WriteLine ("Lixeira Errada");
                                break;
                        }
                        break;

                    case 6:
                        System.Console.WriteLine ("Pote de Manteiga");

                        switch (opcao2) {
                            Console.Clear ();
                            System.Console.WriteLine ("Agora Selecione a lixeira adequada:");
                            Console.Write ("Lixeira: ");

                            case 1:
                                System.Console.WriteLine ("Amarela");
                                break;

                            case 2:
                                System.Console.WriteLine ("Verde");
                                break;

                            case 3:
                                System.Console.WriteLine ("Azul");
                                break;

                            case 4:
                                System.Console.WriteLine ("Vermelha");
                                break;

                            case 5:
                                System.Console.WriteLine ("Marrom");
                                break;

                            case 6:
                                System.Console.WriteLine ("Cinza");
                                break;

                            default:
                                System.Console.WriteLine ("Lixeira Errada");
                                break;
                        }
                        break;

                    default:
                        System.Console.WriteLine ("Sair (Aperte Enter)");

                        switch (opcao2) {
                            Console.Clear ();
                            System.Console.WriteLine ("Agora Selecione a lixeira adequada:");
                            Console.Write ("Lixeira: ");

                            case 1:
                                System.Console.WriteLine ("Amarela");
                                break;

                            case 2:
                                System.Console.WriteLine ("Verde");
                                break;

                            case 3:
                                System.Console.WriteLine ("Azul");
                                break;

                            case 4:
                                System.Console.WriteLine ("Vermelha");
                                break;

                            case 5:
                                System.Console.WriteLine ("Marrom");
                                break;

                            case 6:
                                System.Console.WriteLine ("Cinza");
                                break;

                            default:
                                System.Console.WriteLine ("Lixeira Errada");
                                break;
                        }
                        break;
                }
            } while (opcao != 6);

            do {
                bool lixoEscolhido = false;

                /*
                    ! LIXOS A SEREM JOGADOS FORA
                */
                do {
                    Console.Clear ();

                    System.Console.WriteLine (BarraMenu);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine ("         Seja bem-vindo    ");
                    System.Console.WriteLine ("        Escolha um lixo:      ");
                    Console.ResetColor ();
                    System.Console.WriteLine (BarraMenu);

                    // /*
                    //     ! TROCA A COR DO ITEM
                    // */
                    //     for (int i = 0; i < opcoesFormacao.Count; i++)
                    //     {
                    //         string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                    //         if (opcaoFormacaoSelecionada == i)
                    //         {
                    //             DestacarOpcao(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                    //         }
                    //         else
                    //         {
                    //             System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                    //         }
                    //     }

                    /* 
                        ! LÊ A TECLA SELECIONADA PELO USUÁRIO
                    */

                    var key = Console.ReadKey (true).Key;

                    switch (key) {
                        case ConsoleKey.UpArrow:
                            opcaoSelecionada = opcaoSelecionada == 0 ? opcaoSelecionada : --opcaoSelecionada;
                            break;

                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoSelecionada : ++opcaoSelecionada;
                            break;

                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }
                    #endregion

                } while (!formacaoEscolhida);
                #endregion

                // bool bandaCompleta = false;
                // int vagas = 0;

                #region Adiciona os instrumentos a formação escolhida.

                switch (opcaoFormacaoSelecionada) {
                    #region Cadastro de instrumentos para os trios.
                    case 0:
                        vagas = 2;
                        do {
                            ExibirMenuDeInstrumentos ();

                            Console.Write ($"Digite código do lixo de metal: ");
                            int codigo = int.Parse (Console.ReadLine ());
                            var instrumento = Deposito.Instrumentos[codigo];

                            Type interfaceEncontrada = instrumento.GetType ().GetInterface ("IMetal");

                            if (interfaceEncontrada != null) {
                                vagas--;
                                ColocarNaBanda ((IMetal) instrumento);
                            } else {
                                Console.WriteLine ("O lixo selecionado não é de metal.");
                                continue;
                            }

                            Console.Write ($"Digite código do lixo de papel: ");
                            codigo = int.Parse (Console.ReadLine ());
                            instrumento = Deposito.Instrumentos[codigo];
                            interfaceEncontrada = instrumento.GetType ().GetInterface ("IPapel");

                            if (interfaceEncontrada != null) {
                                vagas--;
                                ColocarNaBanda ((IPapel) instrumento);
                            } else {
                                Console.WriteLine ("O lixo selecionado não é de papel.");
                                continue;
                            }

                            Console.Write ($"Digite código do lixo de plástico: ");
                            int codigo = int.Parse (Console.ReadLine ());
                            var instrumento = Deposito.Instrumentos[codigo];

                            Type interfaceEncontrada = instrumento.GetType ().GetInterface ("IPlastico");

                            if (interfaceEncontrada != null) {
                                vagas--;
                                ColocarNaBanda ((IPlastico) instrumento);
                            } else {
                                Console.WriteLine ("O lixo selecionado não é de plástico.");
                                continue;
                            }

                            Console.Write ($"Digite código do lixo de vidro: ");
                            int codigo = int.Parse (Console.ReadLine ());
                            var instrumento = Deposito.Instrumentos[codigo];

                            Type interfaceEncontrada = instrumento.GetType ().GetInterface ("IVidro");

                            if (interfaceEncontrada != null) {
                                vagas--;
                                ColocarNaBanda ((IVidro) instrumento);
                            } else {
                                Console.WriteLine ("O lixo selecionado não é de vidro.");
                                continue;
                            }

                            if (vagas == 0) {
                                bandaCompleta = true;
                            }

                        } while (!bandaCompleta);

                        System.Console.WriteLine ("Feito!");
                        System.Console.WriteLine ("O Planeta agradece!");
                        Console.ReadLine ();
                        break;
                        #endregion

                        // #region Cadastro de instrumentos para quartetos.
                        // case 1:
                        //     vagas = 3;
                        //     do
                        //     {

                        //         ExibirMenuDeInstrumentos();
                        //         System.Console.Write($"Digite o código do instrumento para a categoria Harmonia: ");
                        //         int codigo = int.Parse(Console.ReadLine());
                        //         var instrumento = Deposito.Instrumentos[codigo];
                        //         Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");

                        //         if (interfaceEncontrada != null)
                        //         {
                        //             vagas--;
                        //             ColocarNaBanda((IHarmonia)instrumento);
                        //         }
                        //         else
                        //         {
                        //             Console.WriteLine("O instrumento selecionado não é de Harmonia.");
                        //             continue;
                        //         }

                        //         System.Console.Write($"Digite o código do instrumento para a categoria Percussao:");
                        //         codigo = int.Parse(Console.ReadLine());
                        //         instrumento = Deposito.Instrumentos[codigo];
                        //         interfaceEncontrada = instrumento.GetType().GetInterface("IPercussao");

                        //         if (interfaceEncontrada != null)
                        //         {
                        //             vagas--;
                        //             ColocarNaBanda((IPercussao)instrumento);
                        //         }
                        //         else
                        //         {
                        //             Console.WriteLine("O instrumento selecionado não é de Percussão.");
                        //             continue;
                        //         }

                        //         System.Console.Write($"Digite o código do instrumento para a categoria Melodia:");
                        //         codigo = int.Parse(Console.ReadLine());
                        //         instrumento = Deposito.Instrumentos[codigo];
                        //         interfaceEncontrada = instrumento.GetType().GetInterface("IMelodia");

                        //         if (interfaceEncontrada != null)
                        //         {
                        //             vagas--;
                        //             ColocarNaBanda((IMelodia)instrumento);
                        //         }
                        //         else
                        //         {
                        //             Console.WriteLine("O instrumento selecionado não é de Melodia.");
                        //             continue;
                        //         }

                        //         if (vagas == 0)
                        //         {
                        //             bandaCompleta = true;
                        //         }

                        //     } while (!bandaCompleta);
                        //     System.Console.WriteLine("Sua banda está completa!");
                        //     Console.ReadLine();
                        //     break;
                        // #endregion

                }
                #endregion
                Console.WriteLine ("Deseja ajudar o planeto de novo? (S/N)");
                string opcao = Console.ReadLine ().ToLower ();

                if (opcao == "n") {
                    querSair = true;
                }

            } while (!querSair);

        }

        #region Coloca os lixos nas lixeiras
        public static bool ColocarNaBanda (IMetal metal) {
            metal.TocarAcordes ();
            System.Console.WriteLine (metal.GetType ().BaseType + " foi jogado");
            return true;
        }

        public static bool ColocarNaBanda (IPapel papel) {
            papel.ManterRitmo ();
            System.Console.WriteLine (papel.GetType ().BaseType + " foi jogado");
            return true;
        }

        public static bool ColocarNaBanda (IPlastico plastico) {
            plastico.TocarSolo ();
            System.Console.WriteLine (plastico.GetType ().BaseType + " foi jogado");
            return true;
        }

        public static bool ColocarNaBanda (IVidro vidro) {
            vidro.TocarSolo ();
            System.Console.WriteLine (vidro.GetType ().BaseType + " foi jogado");
            return true;
        }
        #endregion

        public static void DestacarOpcao (string opcao) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine (opcao);
            Console.ResetColor ();
        }

        public static void ExibirMenuDeInstrumentos () {
            var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";

            System.Console.WriteLine (menuInstrumentoBorda);
            System.Console.WriteLine ("#                            #");
            System.Console.WriteLine ("#        Instrumentos        #");
            System.Console.WriteLine ("#                            #");
            System.Console.WriteLine (menuInstrumentoBorda);

            foreach (var instrumento in instrumentos) {
                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(instrumento)}");
            }

            System.Console.WriteLine (menuInstrumentoBorda);
        }

        public static void ExibirMenuDeCategorias () {
            var categorias = Enum.GetNames (typeof (CategoriaEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";
            System.Console.WriteLine (menuInstrumentoBorda);
            System.Console.WriteLine ("#          Categorias        #");

            foreach (var categoria in categorias) {

                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(categoria)}");
            }

            System.Console.WriteLine (menuInstrumentoBorda);

        }

        // public static string TratarTituloMenu(string titulo)
        // {
        //     return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        // }

    }
}