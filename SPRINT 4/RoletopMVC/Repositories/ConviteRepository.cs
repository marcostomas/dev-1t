using System;
using System.Collections.Generic;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    public class ConviteRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";

        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines (PATH);
            List<Pedido> pedidos = new List<Pedido>();

            foreach(var linha in linhas)
            {
                Pedido pedido = new Pedido();

                pedido.Evento.Observacoes = ExtrairValorDoCampo("evento_observacoes", linha);
                pedido.Evento.NomeParticipantes = ExtrairValorDoCampo("evento_participantes", linha);
            }

            return pedidos;
        }
    }
}