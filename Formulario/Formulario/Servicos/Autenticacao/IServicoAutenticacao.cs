using ProjetoFormulario.Pages.Login.Modelo;
namespace ProjetoFormulario.Servicos.Autenticacao;

public interface IServicoAutenticacao
{
    Task<RespostaAutenticacao> AutentiqueAsync(ModeloLoginUsuario modeloLogin);
}
