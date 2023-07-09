using DooHAdvertAPI.Data;
using DooHAdvertAPI.Repository;
using DooHAdvertAPI.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddCors(option=>
        option.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()));

        builder.Services.AddScoped<ICityRepository,CityRepository>();
        builder.Services.AddEntityFrameworkMySQL()
            .AddDbContext<AppDbContext>(options =>
            {
                options.UseMySQL(builder.Configuration.GetConnectionString("MySqlConnection"));
            });

        builder.Services.AddControllers();
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

        app.UseStaticFiles();

        app.UseCors("CorsPolicy");
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}