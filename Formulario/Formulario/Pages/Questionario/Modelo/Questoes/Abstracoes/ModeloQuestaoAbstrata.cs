using ProjetoFormulario.Enumeradores;

namespace ProjetoFormulario.Pages.Home.Modelo.Questoes.Abstracoes;

public abstract class ModeloQuestaoAbstrata(int id, string descricao, EnumTipoQuestao tipoQuestao)
{
    public int Id { get; private set; } = id;

    public string Descricao { get; private set; } = descricao;

    public EnumTipoQuestao TipoQuestao { get; private set; } = tipoQuestao;
}
