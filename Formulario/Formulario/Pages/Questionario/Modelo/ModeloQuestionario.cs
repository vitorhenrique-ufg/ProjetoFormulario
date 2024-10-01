using ProjetoFormulario.Pages.Home.Modelo.Questoes.Abstracoes;

namespace ProjetoFormulario.Pages.Home.Modelo;

public record class ModeloQuestionario(int Id, string Topico)
{
    private readonly List<ModeloQuestaoAbstrata> _questoes = [];
    public IReadOnlyList<ModeloQuestaoAbstrata> Questoes => _questoes.AsReadOnly();

    public void AdicioneQuestao(ModeloQuestaoAbstrata questao)
    {
        _questoes.Add(questao);
    }
}
