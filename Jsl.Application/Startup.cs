using AutoMapper;
using Jsl.Application.Models;
using Jsl.Domain.Entities;
using Jsl.Domain.Interfaces;
using Jsl.Infra.Data.Context;
using Jsl.Infra.Data.Repository;
using Jsl.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Jsl.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<Db>(
                options => options
                .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IBaseRepository<Motorista>, BaseRepository<Motorista>>();
            services.AddScoped<IBaseService<Motorista>, BaseService<Motorista>>();

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<CreateMotoristaModel, Motorista>();
                config.CreateMap<UpdateMotoristaModel, Motorista>();
                config.CreateMap<Motorista, MotoristaModel>();
            }).CreateMapper());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
