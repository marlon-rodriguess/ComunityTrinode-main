using Trinode.Infrastructure;
using Trinode.Application.Services;

var builder = WebApplication.CreateBuilder(args);

//Adiciono o Serviço de Infraestrutura que armazena os repositorys e o contexto do banco de dados na injeção de dependência
builder.Services.ConfigureInfraServices(builder.Configuration);

//Adiciono os serviços da camada de aplicação na injeção de dependência
builder.Services.AplicationServices();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
