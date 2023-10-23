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

app.MapPost("/adicionar", (Artista artista) =>
{
    entityDAL.Adicionar(artista);

});

app.MapGet("/selecionar", () =>
{
    return entityDAL.Listar();
});



app.Run();


