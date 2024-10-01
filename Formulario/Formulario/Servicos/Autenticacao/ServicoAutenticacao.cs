using Microsoft.Extensions.Options;
using ProjetoFormulario.Options;
using ProjetoFormulario.Pages.Login.Modelo;

namespace ProjetoFormulario.Servicos.Autenticacao;

public sealed class ServicoAutenticacao(IOptions<UrlServicosOptions> options) : IServicoAutenticacao
{
    private readonly IOptions<UrlServicosOptions> _options = options;

    public Task<RespostaAutenticacao> AutentiqueAsync(ModeloLoginUsuario modeloLogin)
    {
        throw new NotImplementedException();
    }
}
