﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Senai.Pizzarias.WebApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
            .AddJsonOptions(options => {
                options.SerializerSettings.NullValueHandling =
                    Newtonsoft.Json.NullValueHandling.Ignore;
                options.SerializerSettings.ReferenceLoopHandling = //recursividade
                    Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            })
            .SetCompatibilityVersion
            (Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Info { Title = "Senai.Pizzarias.WebApi", Version = "v1" });
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseSwagger();

            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Senai.Pizzarias.WebApi");
            //});

            app.UseAuthentication();


            app.UseCors("CorsPolicy");


            app.UseMvc();
        }
    }
}
