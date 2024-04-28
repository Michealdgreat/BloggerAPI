using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using BlogConfig;
using Application;
using Microsoft.Extensions.DependencyInjection;
using Application.Post.CreatePost;

namespace BloggerAPI
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;
            services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            // Add services to the container.


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(CreatePostCommandHandler).Assembly));


            Bootstrapper.ConfigBootstrapper(services);


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
