namespace ProjetoFormulario.Options;

public sealed record UrlServicosOptions
{
	public const string SecaoServicos = "Servicos";

	public Uri UrlApi { get; set; } = null!;
}