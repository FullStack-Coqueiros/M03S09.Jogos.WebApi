using AutoMapper;
using M03S09.Jogos.WebApi.Domain;
using M03S09.Jogos.WebApi.DTOs.Estudios;
using M03S09.Jogos.WebApi.DTOs.Jogos;
using M03S09.Jogos.WebApi.Infra;
using M03S09.Jogos.WebApi.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<JogoDbContext>();

builder.Services.AddScoped<EstudioRepository>();
builder.Services.AddScoped<JogoRepository>();

//Sagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Jogos", Description = "API CRUD JOGOS", Version = "v1" });
});

//Automapper
var config = new MapperConfiguration(cfg =>
{
    //DTO para Domain
    cfg.CreateMap<CreateEstudioDto, Estudio>();
    cfg.CreateMap<UpdateEstudioDto, Estudio>();

    cfg.CreateMap<UpdateJogoDto, Jogo>();
    cfg.CreateMap<CreateJogoDto, Jogo>();


    //Domain para DTO
    cfg.CreateMap<Estudio, ViewEstudioDto>();
    
    cfg.CreateMap<Jogo, ViewJogoDto>();

});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

//Cors
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API JOGOS");
});

//Cors
app.UseCors(p =>
{
    p.AllowAnyOrigin();
    p.AllowAnyHeader();
    p.AllowAnyMethod();
});


app.UseAuthorization();

app.MapControllers();

app.Run();
