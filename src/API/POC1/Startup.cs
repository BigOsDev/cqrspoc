using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Common.Interfaces;
using Demo.Handlers.Event;
using Demo.Handlers.Grid;
using Demo.Models.Grid;
using Demo.Persistance;
using Demo.Persistance.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using POC1.Notification;
using Microsoft.OpenApi.Models;
using Demo.Handlers.Providers;
using Demo.Models.Common;

namespace POC1
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

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()                     
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

       

            services.AddSignalR(hubOptions =>
            {
                hubOptions.EnableDetailedErrors = true;
            });
            
            services.AddDbContext<DemoContext>(options => options.UseInMemoryDatabase(databaseName: "DemoDatabase"));

            services.AddControllers();
            
            services.AddTransient<IBackgroundProcesor, BackgroundProcesor>();
            services.AddTransient<IGridValueChangeCommandHandler, GridValueChangeCommandHandler>();
            services.AddTransient<IBackgroundHandler, BackgroundHandler>();
            services.AddSingleton<IValueChangedEventDelegateProvider, ValueChangedEventDelegateProvider>((provider) => { return new ValueChangedEventDelegateProvider(provider.GetService<IBackgroundHandler>().ValueChangedEventDelegate); } );
            
            services.AddTransient<IEventHandler<IEvent>, GridValueChangeEventHandler>();
            services.AddTransient<IEventRepository, EventRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseCors("MyPolicy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<EventNotifications>("eventNotifications");
                endpoints.MapControllers();
            });

        }
    }
}
