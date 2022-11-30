
using GestaoNotas;
using GestaoNotas.IRepository;
using GestaoNotas.Repositorio.IRepository;
using GestaoNotas.Repositorio.Repository;
using GestaoNotas.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();
builder.Services.AddScoped<IProfRepository, ProfessorRepository>();
builder.Services.AddScoped<IDiciplinaRepository, DiciplinaRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);


var app = builder.Build();
startup.Configure(app, app.Environment);

app.Run();