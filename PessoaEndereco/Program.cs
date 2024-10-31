// "In ASP.NET Core, services such as the DB context must be registered with the dependency injection (DI) container. The container provides the service to controllers."

using Microsoft.EntityFrameworkCore;
using CadastroPessoas.Models;
using CadastroPessoas.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<CadastroPessoasDB>(opt => opt.UseInMemoryDatabase("CadastroPessoas"));
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run(); 