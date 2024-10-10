
using MyWebApi.Application.Services.Joke;
using MyWebApi.Configuration;
using MyWebApi.Integration.ChuckNorrisApi.Clients;
using MyWebApi.Integration.ChuckNorrisApi.Services;

namespace MyWebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        builder.Services.AddTransient<IJokeService, JokeService>();
        builder.Services.AddTransient<IChuckNorrisApiIntegrationService, ChuckNorrisApiIntegrationService>();

        // Register the typed HttpClient with the interface
        builder.Services.AddHttpClient<IChuckNorrisApiIntegrationClient, ChuckNorrisApiIntegrationClient>(client =>
        {
            var settings = new ChuckNorrisApiConfiguration();
            builder.Configuration.GetSection(ChuckNorrisApiConfiguration.SectionName).Bind(settings);

            client.BaseAddress = new Uri(settings.BaseUrl);
        });

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddControllers();

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
