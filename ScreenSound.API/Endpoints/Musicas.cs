using Microsoft.AspNetCore.Mvc;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;

namespace ScreenSound.API.Endpoints;

public static class Musicas
{
    public static void AddEndPointMusicas(this WebApplication app)
    {
    
            app.MapPost("/Musicas", ([FromServices]EntityDAL<Musica> entityDAL,[FromBody] Musica musica) =>
            {
                entityDAL.Adicionar(musica);
            });
    
            app.MapGet("/Musicas", ([FromServices] EntityDAL<Musica> entityDAL) =>
            {
                return entityDAL.Listar();
            });
    
            app.MapGet("/Musicas/{nome}", ([FromServices]EntityDAL<Musica> entityDAL,string nome) =>
            {
                return entityDAL.RecuperarPor(a => a.Nome == nome);
            });
    
            app.MapDelete("/Musicas", ([FromServices]EntityDAL<Musica> entityDAL,[FromBody] Musica musica) =>
            {
                entityDAL.Deletar(musica);
            });
    
            app.MapPut("/Musicas", ([FromServices]EntityDAL<Musica> entityDAL,[FromBody] Musica musica) =>
            {
                entityDAL.Atualizar(musica);
            });
        }   
}
