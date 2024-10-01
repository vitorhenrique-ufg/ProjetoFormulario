namespace ProjetoFormulario.Componentes.ControleCampo.CampoRadioButton;

public sealed record class ModeloRadioButton<T>
{
    public T Valor { get; private set; }
    public string Descricao { get; private set; }

    public ModeloRadioButton(T valor, string descricao)
    {
        Valor = valor;
        Descricao = descricao;
    }   
}

