using Microsoft.EntityFrameworkCore;
using DAL;

var builder = WebApplication.CreateBuilder(args);//Recibe parametros de la consola

// Add services to the container.

builder.Services.AddControllers();

 var ConStr = builder.Configuration.GetConnectionString("ConStr");

builder.Services.AddDbContext<Contexto>(options =>  options.UseSqlite(ConStr));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();//Explorar la app
builder.Services.AddSwaggerGen();//Documentacion de API

var app = builder.Build();//Se construya la app 

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();//Para que el swagger se use
    app.UseSwaggerUI();// Para que el usuario
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
