using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.AutoMapper;
using Aplication.Interfaces;
using Aplication.Services;
using AutoMapper;
using Data.DataContext;
using Data.Interfaces.Repository;
using Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Api
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
            var connection = "Server=localhost;DataBase=pedidos;Uid=root;Pwd=";
            services.AddDbContext<PedidosDataContext>(options => options.UseMySql(connection));
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddAutoMapper(x => x.AddProfile(new ViewModelToModel()));
            services.AddCors();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder => builder
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials());
            app.UseMvc();
        }
    }
}
