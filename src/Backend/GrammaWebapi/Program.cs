using GrammaWebapi;
using GrammaWebapi.Domain;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddEndpointDefinitions(typeof(Program));
builder.Services.AddSwaggerGen();

builder.Services.AddDomain();
builder.Services.AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();

app.UseHttpsRedirection();
app.MapControllers();


app.Run();

