using ProjetoFormulario.Enumeradores;
using ProjetoFormulario.Pages.Home.Modelo.Questoes.Abstracoes;

namespace ProjetoFormulario.Pages.Home.Modelo.Questoes;

public sealed class ModeloQuestaoSubjetiva(int id, string descricao) : ModeloQuestaoAbstrata(id, descricao, EnumTipoQuestao.Subjetiva)
{
    public string Texto { get; set; } = string.Empty;
}
