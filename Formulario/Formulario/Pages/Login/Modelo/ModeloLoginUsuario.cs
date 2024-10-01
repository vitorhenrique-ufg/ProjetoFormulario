using System.ComponentModel.DataAnnotations;

namespace ProjetoFormulario.Pages.Login.Modelo;

public sealed record ModeloLoginUsuario
{
    [Required(ErrorMessage = "É necessário informar o login.")]
    public string Login { get; set; } = string.Empty;

    [Required(ErrorMessage = "É necessário informar a senha.")]
    public string Senha { get; set; } = string.Empty;
}
