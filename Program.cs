using Microsoft.EntityFrameworkCore;
using mom4.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Db anslutning

builder.Services.AddDbContext<ApplicationDbContext> ( options => {
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbString"));
});

var app = builder.Build();



app.UseHttpsRedirection();



app.Run();

