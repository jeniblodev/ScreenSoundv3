using ScreenSound.API.Endpoints;
using ScreenSound.API.InjecaoDeDependencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInjecaoDeDependencia();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.AddEndPointArtistas();
app.AddEndPointMusicas();

app.Run();


