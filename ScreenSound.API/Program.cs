using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var contexto = new ScreenSoundContext();

app.MapPost("/adicionar", (Artista artista) =>
{
    
    contexto.Artistas.Add(artista);
    contexto.SaveChanges();
});

app.MapGet("/selecionar", () =>
{
    return contexto.Artistas.ToList();
});

app.Run();


