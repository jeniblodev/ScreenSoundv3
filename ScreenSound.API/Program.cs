using ScreenSound.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.AddEndPointArtistas();
app.AddEndPointMusicas();

app.Run();


