using Api_PlataformaJogos.Models.Contexto;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Conectar banco de dados
ContextoJogo contexto = new ContextoJogo();
contexto.Database.EnsureCreated();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opcoes => 
opcoes.SwaggerDoc("v1", new Microsoft.OpenApi.OpenApiInfo
{
    Title = "API Plataforma de Jogos",
    Version = "v1",
    Description = "API didático para cadastro de jogos, estudios e usuarios; realizando operações CRUD em banco de dados SQL.",
}));

builder.Services.AddSwaggerGen(opcoes =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlCaminho = Path.Combine(AppContext.BaseDirectory, xmlFile);
    opcoes.IncludeXmlComments(xmlCaminho);


});

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirAcesso", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    //SWAGGER
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Plataforma de Jogos v1");
        c.DocumentTitle = "Documentação da API Plataforma de Jogos";
    });
}

app.UseCors("PermitirAcesso");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
