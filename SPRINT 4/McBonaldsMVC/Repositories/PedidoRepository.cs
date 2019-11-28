using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";
        public PedidoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Pedido pedido)
        {
            var quantidadedeLinhas = File.ReadAllLines(PATH).Length;
            pedido.Id = (ulong)++quantidadedeLinhas;
            //↑ Conversão forçada de int para uint, sem usar 'Parse()', que serve apenas para string ↑
            var linha = new string[] { PrepararRegistroCSV(pedido) };
            //↓ AppendAllLines = acrescenta linhas a um arquivo e fecha o arquivo ↓
            File.AppendAllLines(PATH, linha);
            return true;
        }

        public List<Pedido> ObterTodos()
        {
            //ReadAllLines = Abre um arquivo de texto, lê todas as linhas do arquivo em uma matriz de cadeia de caracteres e o fecha
            var linhas = File.ReadAllLines(PATH);

            List<Pedido> pedidos = new List<Pedido>();

            foreach (var linha in linhas)
            {
                Pedido pedido = new Pedido();

                pedido.Id = ulong.Parse(ExtrairValorDoCampo("cliente_nome", linha));
                pedido.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCampo("cliente_endereco", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCampo("hamburguer_nome" , linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguer_preco", linha));
                pedido.Shake.Nome = ExtrairValorDoCampo("shake_nome", linha);
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("shake_preco", linha));
                pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("dataDoPedido", linha));
                pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("precoTotal", linha));
                
                pedidos.Add(pedido);
            }

            return pedidos;
        }

        //Verificar se o EMAIL é igual para verificação 
        public List<Pedido> ObterTodosPorCliente(string email)
        {
            var pedidosTotais = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();
            foreach (var pedido in pedidosTotais)
            {
                if(pedido.Cliente.Email.Equals(email))
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }

        public Pedido ObterPor(ulong id)
        {
            var pedidosTotais = ObterTodos();
            foreach(var pedido in pedidosTotais)
            {
                if(pedido.Id == id)
                {
                    return pedido;
                }
            }
            return null;
        }

        private string PrepararRegistroCSV (Pedido pedido)
        {
            return $"id={pedido.Id};status_pedido={pedido.Status};cliente_nome={pedido.Cliente.Nome};cliente_endereco={pedido.Cliente.Endereco};cliente_telefone={pedido.Cliente.Telefone};cliente_email={pedido.Cliente.Email};hamburguer_nome={pedido.Hamburguer.Nome};hamburguer_preco={pedido.Hamburguer.Preco};shake_nome={pedido.Shake.Nome};shake_preco={pedido.Shake.Preco};dataDoPedido={pedido.DataDoPedido};precoTotal={pedido.PrecoTotal}";
        }
    }
}