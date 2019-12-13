using System;
using System.Collections.Generic;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";

        public PedidoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create (PATH).Close();
            }
        }

        public bool Inserir (Pedido pedido)
        {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            pedido.Id = (ulong)  ++quantidadePedidos;
            var linha = new string[] {PrepararPedidoCSV (pedido)};
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Pedido> ObterTodosPorCliente(string emailCliente)
        {
            var pedidos = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();

            foreach(var pedido in pedidos)
            {
                if(pedido.Cliente.Email.Equals(emailCliente))
                {
                    pedidosCliente.Add(pedido);
                }
            }

            return pedidosCliente;
        }

        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines (PATH);
            List<Pedido> pedidos = new List<Pedido>();

            foreach(var linha in linhas)
            {
                Pedido pedido = new Pedido();

                pedido.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                pedido.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));


                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                pedido.Cliente.CPF = ulong.Parse(ExtrairValorDoCampo("cliente_cpf", linha));
                pedido.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);


                pedido.Evento.Nome = ExtrairValorDoCampo("evento_nome", linha);
                pedido.DataDoEvento = DateTime.Parse(ExtrairValorDoCampo("evento_data", linha));
                pedido.HoraDoEvento = DateTime.Parse(ExtrairValorDoCampo("evento_hora", linha));
                pedido.Evento.Observacoes = ExtrairValorDoCampo("evento_observacoes", linha);

                //TODO: Verificar se será através do atributo 'PrecoTotal (soma)' ou o evento já vem definido seu preço
                //! CANCELADO : Em 05/12 (4)
                // pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                // pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));
                pedidos.Add(pedido);
            }

            return pedidos;
        }

        public Pedido ObterPor(ulong id)
        {
            var pedidosTotais = ObterTodos();

            foreach(var pedido in pedidosTotais)
            {
                if(id.Equals(pedido.Id))
                {
                    return pedido;
                }
            }

            return null;
        }

        public bool Atualizar(Pedido pedido)
        {
            var pedidosTotais = File.ReadAllLines(PATH);
            var pedidoCSV = PrepararPedidoCSV(pedido);
            var linhaPedido = -1;
            var resultado = false;

            for (int i  = 0; i < pedidosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", pedidosTotais[i]));

                if(pedido.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                pedidosTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines(PATH, pedidosTotais);
            }

            return resultado;
        }

        private string PrepararPedidoCSV (Pedido pedido)
        {
            Cliente c = pedido.Cliente;
            Evento e = pedido.Evento;

            //TODO: Terminar 'return'
            // *  TERMINADO. Em 05/12 (4)
            return $"id={pedido.Id};status_pedido={pedido.Status};cliente_nome={pedido.Cliente.Nome};cliente_cpf={pedido.Cliente.CPF};cliente_telefone={pedido.Cliente.Telefone};cliente_email={pedido.Cliente.Email};evento_nome={pedido.Evento.Nome};evento_data={pedido.DataDoEvento};evento_hora={pedido.HoraDoEvento};evento_observacoes={pedido.Evento.Observacoes};";

            // evento_hora={pedido.HoraDoEvento}
        }
    }
}