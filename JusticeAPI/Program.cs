using MediatR;
using Domain;
using System.Reflection;
using Application;
using Application.Services;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<JusticeDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("JusticeAPIContext"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("JusticeAPIContext"))));

builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddTransient(typeof(IRequestHandler<,>));
builder.Services.AddScoped<IChapterService, ChapterService>();
builder.Services.AddMediatR(typeof(DummyDomain));
builder.Services.AddMediatR(typeof(DummyApplication));

builder.Services.AddCors(options =>
{
    options.AddPolicy("DEV", build =>
    {
        build.WithOrigins("https://localhost:4200", "http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
    });
});

//builder.Services.AddOptions();


var app = builder.Build();

// Configure the HTTP request pipeline.


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("DEV");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
