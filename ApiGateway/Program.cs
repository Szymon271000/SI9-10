//using Ocelot.DependencyInjection;
//using Ocelot.Middleware;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddOcelot();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseRouting();
//app.UseOcelot().Wait();

//app.UseEndpoints(endpoints => {
//    endpoints.MapGet("/", async context => {
//        await context.Response.WriteAsync("Hello World!");
//    });
//});

////app.UseHttpsRedirection();

////app.UseAuthorization();

//app.MapControllers();

//app.Run();

using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddJsonFile($"ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddOcelot();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.UseOcelot();

app.Run();


//using System.IO;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Hosting;
//using Ocelot.DependencyInjection;
//using Ocelot.Middleware;

//namespace OcelotBasic
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            new WebHostBuilder()
//            .UseKestrel()
//            .UseContentRoot(Directory.GetCurrentDirectory())
//            .ConfigureAppConfiguration((hostingContext, config) =>
//            {
//                config
//                    .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
//                    .AddJsonFile("appsettings.json", true, true)
//                    .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
//                    .AddJsonFile("ocelot.json")
//                    .AddEnvironmentVariables();
//            })
//            .ConfigureServices(s =>
//            {
//                s.AddOcelot();
//            })
//            .ConfigureLogging((hostingContext, logging) =>
//            {
//                //add your logging
//            })
//            .UseIISIntegration()
//            .Configure(app =>
//            {
//                app.UseOcelot().Wait();
//            })
//            .Build()
//            .Run();
//        }
//    }
//}