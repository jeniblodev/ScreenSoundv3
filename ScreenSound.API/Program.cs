using ScreenSound.API.Endpoints;
using ScreenSound.API.Services;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<ScreenSoundContext>();
builder.Services.AddTransient(typeof(EntityDAL<Artista>));
builder.Services.AddTransient(typeof(EntityDAL<Musica>));
builder.Services.AddTransient(typeof(ArtistaConverter));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.AddEndPointArtistas();

app.AddEndPointMusicas();

app.Run();


