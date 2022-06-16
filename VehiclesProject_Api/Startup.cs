using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using VehiclesProject_BLL.Abstract;
using VehiclesProject_BLL.Concrete;
using VehiclesProject_DAL;
using VehiclesProject_DAL.Repository.Abstract;
using VehiclesProject_DAL.Repository.Concrete;
using VehiclesProject_EL;

namespace VehiclesProject_Api
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<IBoatService, BoatManager>();
            services.AddScoped<IBusService, BusManager>();

            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBoatRepository, BoatRepository>();
            services.AddScoped<IBusRepository, BusRepository>();
         


            services.AddDbContext<MyDBContext>(options =>
         
            {
                options.UseSqlServer(Configuration.GetConnectionString("LocalConnection"));
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }
    }
}
