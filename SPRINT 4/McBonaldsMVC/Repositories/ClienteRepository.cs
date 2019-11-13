using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";

        // Verifica se o arquivo exite
        public ClienteRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close(); //Cria/sobreescreve um arquivo, escreve nele e fecha-o
            }
        }   
        public bool Inserir (Cliente cliente)
        {
            var linha = new string [] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);
            return true;
        }

        // Pega os dados e escreve no CSV
        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereço={cliente.Endereco};telefne={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
        }
    }
}