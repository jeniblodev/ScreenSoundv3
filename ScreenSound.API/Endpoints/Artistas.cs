using Microsoft.AspNetCore.Mvc;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Modelos;

namespace ScreenSound.API.Endpoints;

public static class Artistas
{

    public static void AddEndPointArtistas(this WebApplication app)
    {
        app.MapPost("/Artistas", ([FromServices] EntityDAL<Artista> entityDAL,[FromBody] Artista artista) =>
        {
            entityDAL.Adicionar(artista);
        });

        app.MapGet("/Artistas", ([FromServices] EntityDAL<Artista> entityDAL) =>
        {
            return entityDAL.Listar();
        });

        app.MapGet("/Artistas/{nome}", ([FromServices] EntityDAL<Artista> entityDAL,string nome) =>
        {
            return entityDAL.RecuperarPor(a => a.Nome == nome);
        });

        app.MapDelete("/Artistas", ([FromServices] EntityDAL<Artista> entityDAL,[FromBody] Artista artista) =>
        {
            entityDAL.Deletar(artista);
        });

        app.MapPut("/Artistas", ([FromServices] EntityDAL<Artista> entityDAL, [FromBody] Artista artista) =>
        {
            entityDAL.Atualizar(artista);
        });
    }
}
