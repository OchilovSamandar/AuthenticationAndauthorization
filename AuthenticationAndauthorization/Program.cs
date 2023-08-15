using AuthenticationAndauthorization.Brokers.StorageBrokers;
using AuthenticationAndauthorization.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//database
string v = builder.Configuration.GetConnectionString("ConnectionStrings");
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(v));

var app = builder.Build();
 static void AddBrokers(IServiceCollection services)
{
    services.AddTransient<IStorageBroker,StorageBroker>();
}


    builder.Services.AddTransient<IStorageBroker, StorageBroker>();

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
