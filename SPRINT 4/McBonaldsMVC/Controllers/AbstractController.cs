using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace McBonaldsMVC.Controllers
{
    //Deixar disponivel a variavel SESSION_CLIENTE_EMAIL para outras classes

    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "SESSION_CLIENTE_EMAIL"; 

        protected const string SESSION_CLIENTE_NOME = "SESSION_CLIENTE_NOME";

        //metodos que auxiliam a obter informações, para diminuir a escrita
        //ObterUsuarioSession() e ObterUsuarioSession
        //HttpContext.Session GetString ou SetString
        //Deixa visivel para todos os controllers as informações que estão em string
        //Guarda uma string qualquer dentro do section 
        //Exemplo: email,nome

        protected string ObterUsuarioSession()
        {
            //Todos os dados do usuario seram apagados com um tempo limite
            var email = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if(!string.IsNullOrEmpty(email))
            {
                return email;
            }
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioNomeSession()
        {
            //Todos os dados do usuario seram apagados com um tempo limite
            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if(!string.IsNullOrEmpty(nome))
            {
                return nome;
            }
            else
            {
                return "";
            }
        }

        //Metodo para gravar na Seção
        
    }
}