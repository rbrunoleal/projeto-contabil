using projeto_contabil.Domain;
using projeto_contabil.Domain.Interface.Services;
using projeto_contabil.Domain.Interface.UseCases;
using projeto_contabil.Services;
using projeto_contabil.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProcessDocumentService, ProcessDocumentService>();
builder.Services.AddTransient<INotasService, NotasService>();
builder.Services.AddTransient<IProcessDocumentUsecase, ProcessDocumentUsecase>();

builder.Services.Configure<DbClient>(builder.Configuration.GetSection("Database"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
