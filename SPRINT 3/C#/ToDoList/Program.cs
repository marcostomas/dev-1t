using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoList {
    class Program {
        static int Main (string[] args) {
            List<ToDoItem> todoList = new List<ToDoItem> ();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            todoList = initList (@filePath);

            if (todoList == null) {
                return -1;
            }

            int opcao = 0;

            do {
                Console.Clear ();
                System.Console.WriteLine ("To-Do List");
                System.Console.WriteLine ();
                ListaItens (todoList);
                System.Console.WriteLine ();
                System.Console.WriteLine ("Digite uma Opção");
                System.Console.WriteLine ("1 - Adicionar Item");
                System.Console.WriteLine ("2 - Remover Item");
                System.Console.WriteLine ("3 - Terminar");
                Console.Write ("Opção: ");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        AddItem (todoList);
                        break;
                    case 2:
                        RemoveItem (todoList);
                        break;
                    case 3:
                        Console.WriteLine ("Tchau!");
                        SaveList (todoList, @filePath);
                        break;
                    default:
                        Console.WriteLine ("Opção Inválida");
                        Console.ReadLine ();
                        break;
                }
            } while (opcao != 3);
            return 0;
        }
        static List<ToDoItem> initList (string filePath) {

            List<ToDoItem> todoList = new List<ToDoItem> ();

            try {
                string[] todoFile = File.ReadAllLines (@filePath);
                foreach (string line in todoFile) {
                    string[] itens = line.Split (",");
                    string titulo = itens[0].Replace ("\"", "");
                    string nota = itens[1].Replace ("\"", "");
                    ToDoItem todoItem = new ToDoItem (titulo, nota);
                    todoList.Add (todoItem);
                }
                todoList.RemoveAt (0);
                return todoList;
            } catch (IOException e) {
                System.Console.WriteLine ("Erro de Acesso.");
                System.Console.WriteLine (e.Message);
                return null;
            }
        }
        static void ListaItens (List<ToDoItem> todoList) {
            Console.Clear ();
            int count = 1;
            System.Console.WriteLine ("To-Do List");
            System.Console.WriteLine ();
            System.Console.WriteLine ($"ID{"",2} Titulo{"",12} Notas");
            foreach (ToDoItem item in todoList) {
                System.Console.WriteLine ($"{count,3}: {item.Titulo,-15} - {item.Nota}");
                count++;
            }
        }
        static void AddItem (List<ToDoItem> todoList) {
            Console.Clear ();
            System.Console.WriteLine ("Novo Item");
            System.Console.WriteLine ();
            Console.Write ("Título: ");
            string titulo = Console.ReadLine ();
            Console.Write ("Nota: ");
            string nota = Console.ReadLine ();
            ToDoItem item = new ToDoItem (titulo, nota);
            todoList.Add (item);
        }

        static void RemoveItem (List<ToDoItem> todoList) {
            int index = 0;

            do {
                Console.Clear ();
                System.Console.WriteLine ("Remove Item");
                System.Console.WriteLine ();
                ListaItens (todoList);

                System.Console.WriteLine ();
                System.Console.WriteLine ("Digite o ID ou x Para Terminar");
                Console.Write ("ID: ");
                string id = Console.ReadLine ();

                if (id.ToLower () == "x") {
                    break;
                } else {
                    index = int.Parse (id) - 1;
                }

                if ((index < 0) || (index > todoList.Count - 1)) {
                    System.Console.WriteLine ("ID Inválido");
                    System.Console.WriteLine ("Pressione <enter> Para Continuar");
                    Console.ReadLine ();
                } else {
                    todoList.RemoveAt (index);
                }
            } while (true);
        }

        static void SaveList (List<ToDoItem> lista, string path) {
            List<string> linhas = new List<string> ();

            foreach (ToDoItem item in lista) {
                string titulo = "\"" + item.Titulo + "\"";
                string nota = "\"" + item.Nota + "\"";
                linhas.Add (titulo + "," + nota);

            }

            string tryAgain = "";

            do {
                try {
                    File.WriteAllLines (@path, linhas);
                    tryAgain = "n";
                } catch (IOException e) {
                    System.Console.WriteLine ("Erro Na Leitura do Arquivo");
                    System.Console.WriteLine (e.Message);
                    do {
                        System.Console.WriteLine ("Deseja Tentar Novamente (S/N)?");
                        tryAgain = Console.ReadLine ().ToLower ();

                        if ((tryAgain != "n") || (tryAgain != "s")) {
                            System.Console.WriteLine ("Opção Inválida");
                        }
                    } while ((tryAgain == "s") || (tryAgain == "n"));
                }
            } while (tryAgain != "n");
        }
    }
}