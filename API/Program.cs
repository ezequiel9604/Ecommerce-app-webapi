
using AutoMapper;
using Domain.Helpers.Mapper;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// setting up connection string for db
builder.Services.AddDbContext<EcommerceAppDbContext>(opts => opts.UseSqlServer(
    builder.Configuration.GetConnectionString("defaultConnection"))
);

// setting up cors
builder.Services.AddCors(c => c.AddPolicy("corsapp", policy =>
{
    policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
}));

// setting up the mapper
var mapConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfileConfiguration());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
