using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapPost("/adicionar", (Artista artista) =>
{
    var contexto = new ScreenSoundContext();
    contexto.Artistas.Add(artista);
    contexto.SaveChanges();
});

app.MapGet("/selecionar", () =>
{
    var contexto = new ScreenSoundContext();
    return contexto.Artistas.ToList();
  
}).WithName("Selecionar");

app.Run();


