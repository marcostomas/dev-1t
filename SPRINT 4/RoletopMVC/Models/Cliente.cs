using System;

namespace RoletopMVC.Models
{
    public class Cliente
    {
        public string Nome {get; set;}
        public ulong CPF {get; set;}
        public string Telefone {get; set;}
        public string Senha {get; set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}
        public uint TipoUsuario {get; set;}

        public Cliente()
        {

        }
        public Cliente(string nome, ulong cpf, string telefone, string senha, string email, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
        }
    }
}