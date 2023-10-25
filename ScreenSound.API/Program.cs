using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ScreenSound.API;
using ScreenSound.API.Endpoints;
using ScreenSound.API.Services;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddIdentity<IdentityUser,IdentityRole>()
    .AddEntityFrameworkStores<ScreenSoundContext>()
    .AddDefaultTokenProviders();
     
builder.Services.AddScoped<ScreenSoundContext>();
builder.Services.AddTransient(typeof(EntityDAL<Artista>));
builder.Services.AddTransient(typeof(EntityDAL<Musica>));
builder.Services.AddTransient(typeof(ArtistaConverter));
builder.Services.AddTransient(typeof(MusicaConverter));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.AddEndPointArtistas();

app.AddEndPointMusicas();

app.AddEndPointAuthorizer();

app.UseAuthentication();

app.Run();


