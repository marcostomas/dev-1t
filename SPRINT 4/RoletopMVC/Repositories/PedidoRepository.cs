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

        public bool Inserir (PedidoRepository pedido)
        {
            var quantidadePedidos = File.ReadLines(PATH).Length;
            pedido.Id = (ulong)  ++quantidadePedidos;
            var linha = new string[] {PrepararRegistroCSV (pedido)};
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
                    pedidos.Cliente.Add(pedido);
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


                pedido.Aniversario.Nome = ExtrairValorDoCampo("aniversario_nome", linha);
                pedido.Aniversario.DataEvento = DateTime.Parse(ExtrairValorDoCampo("aniversario_data", linha));
                pedido.Aniversario.HoraEvento = DateTime.Parse(ExtrairValorDoCampo("aniversario_hora", linha));
                pedido.Aniversario.NomeParticipantes = ExtrairValorDoCampo("aniversario_participantes", linha);


                pedido.Balada.Nome = ExtrairValorDoCampo("balada_nome", linha);
                pedido.Balada.DataEvento = DateTime.Parse(ExtrairValorDoCampo("balada_data", linha));
                pedido.Balada.HoraEvento =DateTime.Parse(ExtrairValorDoCampo("balada_hora", linha));
                pedido.Balada.NomeParticipantes = ExtrairValorDoCampo("balada_participantes", linha);


                pedido.Casamento.Nome = ExtrairValorDoCampo("casamento_nome", linha);
                pedido.Casamento.DataEvento = DateTime.Parse(ExtrairValorDoCampo("casamento_data", linha));
                pedido.Casamento.HoraEvento = DateTime.Parse(ExtrairValorDoCampo("casmento_hora", linha));
                pedido.Casamento.NomeParticipantes = ExtrairValorDoCampo("casamento_participantes", linha);

                //TODO: Verificar se será através do atributo 'PrecoTotal (soma)' ou o evento já vem definido seu preço
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
            Aniversario a = pedido.Aniversario;
            Balada b = pedido.Balada;
            Casamento cas = pedido.Casamento;


            //TODO: Terminar 'return'
            return $"id={pedido.Id};status_pedido={pedido.Status}";
        }
    }
}