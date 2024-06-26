using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using BlogConfig;
using Application;
using Microsoft.Extensions.DependencyInjection;
using Application.Post.CreatePost;
using Application.Post.UpdatePost;
using Application.Post.DeletePost;
using Query.Post.GetByCategory;
using Query.Post.GetById;
using Query.Post.GetByTitle;
using Query.Post.GetAll;

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

            Bootstrapper.ConfigBootstrapper(services);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //services.AddMediatR(cfg =>
            //{
            //    cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            //});


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
