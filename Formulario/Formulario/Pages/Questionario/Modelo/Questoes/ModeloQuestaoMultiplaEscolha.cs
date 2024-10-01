using ProjetoFormulario.Enumeradores;
using ProjetoFormulario.Pages.Home.Modelo.Questoes.Abstracoes;

namespace ProjetoFormulario.Pages.Home.Modelo.Questoes;

public sealed class ModeloQuestaoMultiplaEscolha(int id, string descricao, IEnumerable<ModeloOpcaoQuestaoMultiplaEscolha> opcoes) : ModeloQuestaoAbstrata(id, descricao, EnumTipoQuestao.MultiplaEscolha)
{
    public IEnumerable<ModeloOpcaoQuestaoMultiplaEscolha> Opcoes { get; private set; } = opcoes;

    public int OpcaoSelecionada { get; set; }
}
