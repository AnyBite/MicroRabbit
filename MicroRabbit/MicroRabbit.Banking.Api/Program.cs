using MediatR;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Infra.IoC;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the DbContext
builder.Services.AddDbContext<BankingDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankingDbConnection")));

builder.Services.AddDbContext<TransferDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TransferDbConnection")));


builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));


// Register your own services
DependencyContainer.RegisterServices(builder.Services);

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
