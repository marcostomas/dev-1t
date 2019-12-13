using System;

namespace RoletopMVC.Models
{
    public class Cliente
    {
        public uint TipoUsuario {get; set;}
        public string Nome {get; set;}
        public ulong CPF {get; set;}
        public string Senha {get; set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}
        public string Telefone {get; set;}

        public Cliente()
        {

        }
        public Cliente(string nome, ulong cpf, string senha, string email, DateTime dataNascimento, string telefone)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.Telefone = telefone;
        }
    }
}