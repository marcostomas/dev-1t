using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem.Models {
    public class Lixos {
        string[] lixeiras = { "Verde", "Amarela", "Vermelha","Azul", "Cinza", "Preto"};

        public string JogarLixo () {
            int lixeira = new Random ().Next (lixeiras.Length - 1);
            return lixeiras[lixeira];
        }
    }
}