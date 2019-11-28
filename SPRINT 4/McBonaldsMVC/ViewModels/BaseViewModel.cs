namespace McBonaldsMVC.ViewModels
{
    public class BaseViewModel
    {

        //Foi criada uma Herança dentro de ViewModel para evitar a repetição da escrita
        //Copiar o namespace BaseViewModel
        //Crtl + shitft + setas - tecla de atalhho para mudar tudo
        //Transmitir as infomrações mais basicas - nome, saber se esta logado
        public string NomeView {get;set;}
        public string UsuarioEmail { get; set; }
        public string UsuarioNome { get; set; }
    }
}