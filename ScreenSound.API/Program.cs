using Microsoft.AspNetCore.Mvc;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

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

var entityMusicaDAL = new EntityDAL<Musica>(contexto);

app.MapPost("/Musicas", ([FromBody] Musica musica) =>
{
    entityMusicaDAL.Adicionar(musica);
});

app.MapGet("/Musicas", () =>
{
    return entityMusicaDAL.Listar();
});

app.MapGet("/Musicas/{nome}", (string nome) =>
{
    return entityMusicaDAL.RecuperarPor(a => a.Nome == nome);
});

app.MapDelete("/Musicas", ([FromBody] Musica musica) =>
{
    entityMusicaDAL.Deletar(musica);
});

app.MapPut("/Musicas", ([FromBody] Musica musica) =>
{
    entityMusicaDAL.Atualizar(musica);
});
app.Run();


