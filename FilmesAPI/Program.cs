using FilmesApi.Data;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("FilmeConnection");

            builder.Services.AddDbContext<FilmeContext>(opts => opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Add services to the container.

            builder.Services.AddControllers().AddNewtonsoftJson();

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
        }
    }
}