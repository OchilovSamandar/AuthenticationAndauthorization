using AuthenticationAndauthorization.Brokers.StorageBrokers;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//database
builder.Services.AddDbContext<StorageBroker>();
var app = builder.Build();
 static void AddBrokers(IServiceCollection services)
{
    services.AddTransient<IStorageBroker,StorageBroker>();
}

 static void AddBrokers(IServiceCollection services)
{
    services.AddTransient<IStorageBroker, StorageBroker>();
}
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
