using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ScreenSound.API;
using ScreenSound.API.Endpoints;
using ScreenSound.API.Services;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Context;
using ScreenSound.Shared.Modelos;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ScreenSoundContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
   // options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
   // options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
   
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true, 
            ValidIssuer = builder.Configuration["JWTTokenConfiguration:Issuer"],
            ValidAudience = builder.Configuration["JWTTokenConfiguration:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                builder.Configuration["JWTTokenConfiguration:SigningKey"]!))
        };
    });

builder.Services.AddAuthorization();

builder.Services.AddScoped<ScreenSoundContext>();
builder.Services.AddTransient(typeof(EntityDAL<Artista>));
builder.Services.AddTransient(typeof(EntityDAL<Musica>));
builder.Services.AddTransient(typeof(ArtistaConverter));
builder.Services.AddTransient(typeof(MusicaConverter));
builder.Services.AddTransient(typeof(TokenService));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapEndPointAuthorizer();

app.MapEndPointArtistas();

app.MapEndPointMusicas();

app.Run();


