using Microsoft.Extensions.Options;
using ProjetoFormulario.Options;

namespace ProjetoFormulario.Servicos.Formularios;

public sealed class ServicoConsultaFormulario(IOptions<UrlServicosOptions> options) : IServicoConsultaFormulario
{
    private readonly IOptions<UrlServicosOptions> _options = options;

    public Task ConsulteFormularios()
    {
        throw new NotImplementedException();
    }
}

