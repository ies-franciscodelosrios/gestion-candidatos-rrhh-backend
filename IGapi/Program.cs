using IGapi.Context;
using IGapi.Controllers;
using IGapi.Repositories;
using IGapi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));

builder.Services.AddScoped<CandidateRepository>();
builder.Services.AddScoped<CandidateService>();
builder.Services.AddScoped<CandidateController>();
builder.Services.AddScoped<Offer_ApplicationRepository>();
builder.Services.AddScoped<Offer_ApplicationService>();
builder.Services.AddScoped<Offer_ApplicationController>();






// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
