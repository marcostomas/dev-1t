using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{

    //! ESTE ASSSEMBLY VERIFICA SE O USUÁRIO ESTÁ LOGADO E SE ESTÁ PEGA OS DADOS 'EMAIL', 'NOME', 'TIPO (ADMIN/USER PADRÃO)'
    public class AbstractController : Controller
    {
        protected const string SESSION_CLINETE_EMAIL = "cliente_email";
        protected const string SESSION_CLINETE_NOME = "cliente_nome";
        protected const string SESSION_CLINETE_TIPO = "cliente_tipo";

        protected string ObterUsuarioSession()
        {
            var email = HttpContext.Session.GetString(SESSION_CLINETE_EMAIL);
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
            var nome = HttpContext.Session.GetString(SESSION_CLINETE_NOME);
            if(!string.IsNullOrEmpty(nome))
            {
                return nome;
            }
            //TODO: Verificar as ações do método 'ObterUsusarioNomeSession' e o que realiza o else
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioTipoSession()
        {
            var tipoUsuario = HttpContext.Session.GetString(SESSION_CLINETE_TIPO);
            if(!string.IsNullOrEmpty(tipoUsuario))
            {
                return tipoUsuario;
            }
            else
            {
                return "";
            }
        }
    }
}