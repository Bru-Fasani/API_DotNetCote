using FilmesApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o contexto na memória
builder.Services.AddDbContext<FilmeContext>(opt => opt.UseInMemoryDatabase("FilmesDb"));

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
