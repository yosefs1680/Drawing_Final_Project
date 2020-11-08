using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Contracts;
using DALContracts;
using DI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ORDAL;

namespace DrawingApp
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
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dlls/netcoreapp3.1");
            var resolver = new Resolver(path, services);
            services.AddSingleton<IResolver>(sp => resolver);
            services.AddSingleton<IDALinfra, DALinfra>();
            services.AddSwaggerGen();
            services.AddControllers();
            services.AddSingleton<IDbConnection>((sp) =>
                new SqlConnection(this.Configuration.GetConnectionString("appDbConnection")));
            services.AddControllers().AddNewtonsoftJson();
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(5);//You can set Time   
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
    
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
