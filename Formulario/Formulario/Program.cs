using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProjetoFormulario;
using ProjetoFormulario.Gerenciadores.Navegacao;
using ProjetoFormulario.Options;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IGerenciadorNavegacao, GerenciadorNavegacao>();
builder.Services.Configure<UrlServicosOptions>(options =>
{
    builder.Configuration.GetSection(UrlServicosOptions.SecaoServicos).Bind(options);
});
await builder.Build().RunAsync();
