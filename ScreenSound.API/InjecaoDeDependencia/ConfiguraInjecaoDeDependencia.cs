using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;

namespace ScreenSound.API.InjecaoDeDependencia;

public static class ConfiguraInjecaoDeDependencia
{
    public static void AddInjecaoDeDependencia(this IServiceCollection services)
    {
        services.AddScoped<ScreenSoundContext>();
        services.AddScoped(typeof(EntityDAL<Artista>));
        services.AddScoped(typeof(EntityDAL<Musica>));
    }
}
