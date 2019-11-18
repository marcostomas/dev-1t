using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository
    {
        private const string PATH = "Database/Pedido.csv";

        public PedidoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close(); // Cria/sobreescreve um arquivo, escreve nele e fecha-o
            }
        }
        public bool Inserir(Pedido pedido)
        {
            var linha = new string []{PrepararRegistroCSV(pedido)};
            File.AppendAllLines(PATH, linha);
            return true;
        }

        private string PrepararRegistroCSV(Pedido pedido)
        {   
            // Não necessita fazer as atribuições (coisas do César)
            Cliente cliente = pedido.Cliente;
            Hamburguer hamburguer = pedido.Hamburguer;
            Shake shake = pedido.Shake;

            return $"cliente_nome={cliente.Nome};cliente_endereco={cliente.Endereco};cliente_telefone={cliente.Telefone};cliente_email={cliente.Email};hamburguer_nome={hamburguer.Nome};hamburguer_preco={hamburguer.Preco};shake_nome={shake.Nome};shake_preco={shake.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}";
            
            
        }
    }   
}