using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackRestaurante.Domain.Interfaces;
using BackRestaurante.Infra.Data.Context;
using BackRestaurante.Infra.Data.Repository;
using BackRestaurante.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BackRestaurante.Aplication
{
    public class Startup
    {
        private object config;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.ConfigCors();

            services.ConfigureSqlServer(Configuration);

            services.AddTransient<IRepositoryRestaurante, RestauranteRepository>();
            services.AddTransient<IServiceRestaurante,RestauranteService> ();

            services.AddTransient<IRepositoryPrato, PratoRepository>();
            services.AddTransient<IServicePrato, PratoService>();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
               
                app.UseHsts();
            }
            app.UseCors("Policy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
