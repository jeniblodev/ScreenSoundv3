using Microsoft.AspNetCore.Mvc;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;

namespace ScreenSound.API.Endpoints;

public static class Musicas
{
    public static void AddEndPointMusicas(this WebApplication app)
    {
            var contexto = new ScreenSoundContext();
            var entityDAL = new EntityDAL<Musica>(contexto);
    
            app.MapPost("/Musicas", ([FromBody] Musica musica) =>
            {
                entityDAL.Adicionar(musica);
            });
    
            app.MapGet("/Musicas", () =>
            {
                return entityDAL.Listar();
            });
    
            app.MapGet("/Musicas/{nome}", (string nome) =>
            {
                return entityDAL.RecuperarPor(a => a.Nome == nome);
            });
    
            app.MapDelete("/Musicas", ([FromBody] Musica musica) =>
            {
                entityDAL.Deletar(musica);
            });
    
            app.MapPut("/Musicas", ([FromBody] Musica musica) =>
            {
                entityDAL.Atualizar(musica);
            });
        }   
}
