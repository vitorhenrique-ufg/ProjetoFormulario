using Microsoft.AspNetCore.Components;

namespace ProjetoFormulario.Gerenciadores.Navegacao;

public sealed class GerenciadorNavegacao(NavigationManager navitagionManager) : IGerenciadorNavegacao
{
    private readonly NavigationManager _gerenciadorNavegacao = navitagionManager;
    public void Navegue(string rota)
    {
        _gerenciadorNavegacao.NavigateTo(rota);
    }
}
