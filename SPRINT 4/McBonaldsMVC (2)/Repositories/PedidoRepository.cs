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
            var linha = new string[] { PrepararRegistroCSV(pedido) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido> ();

            foreach(var linha in linhas)
            {
                Pedido pedido = new Pedido();
                //! Cliente
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCampo("cliente_endereco", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                //! Hamburguer
                pedido.Hamburguer.Nome = ExtrairValorDoCampo("hamburguer_nome", linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguer_preco", linha));
                //! Shake
                pedido.Shake.Nome = ExtrairValorDoCampo("shake_nome", linha);
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("shake_preco", linha));
                //! Final Pedido
                pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));
                pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));

                pedidos.Add(pedido);

            }
            return pedidos;
        }

        //! Parte de um Cliente Específico
        public List<Pedido> ObterTodosPorCliente(string email)
        {
            var pedidosTotais = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();
            foreach(var pedido in pedidosTotais)
            {
                if(pedido.Cliente.Email.Equals(email))
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }

        private string PrepararRegistroCSV (Pedido pedido)
        {
            return $"cliente_nome={pedido.Cliente.Nome};cliente_endereco={pedido.Cliente.Endereco};cliente_telefone={pedido.Cliente.Telefone};cliente_email={pedido.Cliente.Email};hamburguer_nome={pedido.Hamburguer.Nome};hamburguer_preco={pedido.Hamburguer.Preco};shake_nome={pedido.Shake.Nome};shake_preco={pedido.Shake.Preco};dataDoPedido={pedido.DataDoPedido};precoTotal={pedido.PrecoTotal}";
        }
    }
}