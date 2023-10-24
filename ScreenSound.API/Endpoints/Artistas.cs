using Microsoft.AspNetCore.Mvc;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;

namespace ScreenSound.API.Endpoints;

public static class Artistas
{

    public static void AddEndPointArtistas(this WebApplication app)
    {
        var contexto = new ScreenSoundContext();
        var entityDAL = new EntityDAL<Artista>(contexto);

        app.MapPost("/Artistas", ([FromBody] Artista artista) =>
        {
            entityDAL.Adicionar(artista);
        });

        app.MapGet("/Artistas", () =>
        {
            return entityDAL.Listar();
        });

        app.MapGet("/Artistas/{nome}", (string nome) =>
        {
            return entityDAL.RecuperarPor(a => a.Nome == nome);
        });

        app.MapDelete("/Artistas", ([FromBody] Artista artista) =>
        {
            entityDAL.Deletar(artista);
        });

        app.MapPut("/Artistas", ([FromBody] Artista artista) =>
        {
            entityDAL.Atualizar(artista);
        });
    }
}
