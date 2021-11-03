using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using TerapicFisicHelper.Data;

namespace TerapicFisicHelper.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "TerapicFisicHelper.Web",
                    Version = "v1",
                    Description = "API TerapicFisicHelper del curso Aplicaciones Web con NetCore",
                    TermsOfService = new Uri("https://github.com/K-boom-Team/Server-Side"),
                    Contact = new OpenApiContact
                    {
                        Name = "Grupo KBOOM TEAM - TerapicFisicHelper",
                        Url = new Uri("https://github.com/K-boom-Team/Server-Side")
                    }
                });
            });

            services.AddDbContext<DbContextTerapicFisicHelperApp>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexionTFH")));

            services.AddCors(options => {
                options.AddPolicy("DemoTerapicFisicHelper",
                    builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TerapicFisicHelper.Web v1"));
            }

            app.UseCors("DemoTerapicFisicHelper");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
