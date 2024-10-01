namespace ProjetoFormulario.Componentes.ControleCampo.CampoRadioButton;

public sealed class ModeloRadioButtonSimNao : List<ModeloRadioButton<bool>>
{
    public ModeloRadioButtonSimNao()
    {
        Add(new(true, "Sim"));
        Add(new(false, "Não"));
    }
}

