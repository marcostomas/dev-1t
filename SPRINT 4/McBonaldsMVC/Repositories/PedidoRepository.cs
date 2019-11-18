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
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Pedido pedido)
        {
            var linha = new string[] { PrepararRegistroCSV(pedido) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        private string PrepararRegistroCSV (Pedido pedido)
        {
            return $"cliente_nome={pedido.Cliente.Nome};cliente_endereco={pedido.Cliente.Endereco};cliente_telefone={pedido.Cliente.Telefone};cliente_email={pedido.Cliente.Email};hamburguer_nome={pedido.Hamburguer.Nome};hamburguer_preco={pedido.Hamburguer.Preco};shake_nome={pedido.Shake.Nome};shake_preco={pedido.Shake.Preco};dataDoPedido={pedido.DataDoPedido};precoTotal={pedido.PrecoTotal}";
        }
    }
}