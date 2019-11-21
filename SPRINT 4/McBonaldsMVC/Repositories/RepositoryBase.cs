namespace McBonaldsMVC.Repositories
{
    public class RepositoryBase
    {
        public string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            // Acha a posição do parâmetro do método ↓
            var indiceChave = linha.IndexOf(chave);

            var indiceTerminal = linha.IndexOf(";", indiceChave);
            var valor = "";

            if(indiceTerminal != -1)
            {
                // ↓ Pega uma parte da string e remove a mesma ↓
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }else{
                valor = linha.Substring(indiceChave);
            }

            System.Console.WriteLine($"Campo {nomeCampo} tem valor {valor}");
            // ↓ Troca o que está do lado esquerdo pelo direito ↓
            return valor.Replace(nomeCampo + "=","");
        }
    }
}