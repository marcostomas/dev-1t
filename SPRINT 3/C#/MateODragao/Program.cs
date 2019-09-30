﻿using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {

            bool jogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("        Mate o Dragão");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1 - Iniciar Jogo");
                System.Console.WriteLine (" 0 - Sair do Jogo");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();

                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "Henrique IV";
                        guerreiro.Sobrenome = "Do Sacro Império Romano-Germânico";
                        guerreiro.CidadeNatal = "Roma";
                        guerreiro.DataNascimento = DateTime.Parse ("12/07/1168");
                        guerreiro.FerramentaAtaque = "Espada";
                        guerreiro.FerramentaProtecao = "Escudo";
                        guerreiro.Forca = 3;
                        guerreiro.Destreza = 3;
                        guerreiro.Inteligencia = 2;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "DregDreg";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /* INÍCIO - PRIMEIRO DIÁLOGO */

                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, Seu louco! Vim ARREGAÇAR com você!");

                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: kkkk, vem tranquilo, kkkk");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        /* FIM - PRIMEIRO DIÁLOGO */

                        /* INÍCIO - SEGUNDO DIÁLOGO */

                        Console.Clear ();

                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome} {guerreiro.Sobrenome} ");

                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} pra te quebrar na porrada!");

                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Maneiro ó grande jogador de GARENA, kkkkk");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        /* FIM - SEGUNDO DIÁLOGO */

                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        /* guerreiro.Forca > guerreiroInteligencia ? true;*/

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /* INICIO - TRETA */

                        if (jogadorAtacaPrimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("Turno do Jogador");
                            System.Console.WriteLine ("Escolha su Ação");
                            System.Console.WriteLine ("1 - ATACAR");
                            System.Console.WriteLine ("2 - FUGIR");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();

                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Leva essa aqui bem no reto");

                                        dragao.Vida -= poderAtaqueGuerreiro + 5;

                                        System.Console.WriteLine ("===========================");

                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");

                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()} Errouu, jogador de garena");
                                    }
                                    break;

                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Aee VLW FLW");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: gg easy");

                                    break;
                            }

                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                                Console.Clear ();
                                System.Console.WriteLine ("========= Turno do Dragão========");
                                
                                Random geradorNumeroAleatorio = new Random ();
                                int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Grrrrrrrrr");

                                    guerreiro.Vida -= dragao.Forca;

                                    System.Console.WriteLine ("===========================");

                                    System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");

                                } else {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errouu, jogador de garena");
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();

                                /* INÍCIO - TURNO JOGADOR */

                                Console.Clear ();
                                opcaoBatalhaJogador = Console.ReadLine ();

                                switch (opcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatorio = new Random ();

                                        numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                        numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                        guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                        dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                        if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Leva essa aqui bem no reto");

                                            dragao.Vida -= poderAtaqueGuerreiro + 5;

                                            System.Console.WriteLine ("===========================");

                                            System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");

                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()} Errouu, jogador de garena");
                                        }

                                        if (guerreiro.Vida <= 0){
                                            System.Console.WriteLine("Faliceu!");
                                        }
                                        
                                        if (dragao.Vida <= 0){
                                            System.Console.WriteLine("DregDreg Faliceu!");
                                        }

                                        System.Console.WriteLine();
                                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                                        Console.ReadLine();
                                        
                                    break;

                                    case "2":
                                        jogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Aee VLW FLW");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: gg easy");

                                    break;
                                }
                            }

                            System.Console.WriteLine();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                        }

                    break;
                    /* FIM - TURNO JOGADOR */
                    
                    /* FIM - TRETA */
                    
                    case "0":
                    break;

                    default:
                        System.Console.WriteLine ("Comando desconhecido");
                    break;
                }
            } while (jogadorNaoDesistiu);

        }
    }
}