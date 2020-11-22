using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System.Web.Http.Description;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Database;
using RentAndDrive.WebAPI.Filters;
using RentAndDrive.WebAPI.Security;
using RentAndDrive.WebAPI.Services;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;

namespace RentAndDrive.WebAPI
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).AddRazorPagesOptions(options =>
            {
                options.Conventions.AddPageRoute("/Swagger", "");
            });

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddControllers();

            string connectionString = Configuration.GetConnectionString("RentAndDrive");
            services.AddDbContext<_190151Context>(o => o.UseSqlServer(connectionString));

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic" }
                        }, new string[] { } }
                });
            });


            services.AddScoped<ICRUDService<Model.Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest>, BaseCRUDService<Model.Drzave, object, Database.Drzave, DrzaveUpsertRequest, DrzaveUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Proizvodjaci, object, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest>, BaseCRUDService<Model.Proizvodjaci, object, Database.Proizvodjaci, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Automobili, AutomobiliSearchRequest, AutomobiliUpsertRequest, AutomobiliUpsertRequest>, AutomobilService>();
            services.AddScoped<ICRUDService<Model.Proizvodjaci, object, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest>, BaseCRUDService<Model.Proizvodjaci, object, Database.Proizvodjaci, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Modeli, ModeliSearchRequest, ModeliUpsertRequest, ModeliUpsertRequest>, ModeliService>();
            services.AddScoped<ICRUDService<Model.Ocjene, OcjeneSearchRequest, OcjeneUpsertRequest, OcjeneUpsertRequest>, OcjeneService>();
            services.AddScoped<IKupacService, KupacService>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Database.Uloge>>();
            services.AddScoped<ICRUDService<Model.Racuni, RacuniSearchRequest, RacuniUpsertRequest, RacuniUpsertRequest>, RacunService>();
            services.AddScoped<ICRUDService<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>, RezervacijeService>();
            services.AddScoped<IService<Model.Gradovi, object>, BaseService<Model.Gradovi, object, Database.Gradovi>>();
            services.AddScoped<ILoginService, LoginService>();

            services.AddScoped<IPreporukeService, PreporukeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
