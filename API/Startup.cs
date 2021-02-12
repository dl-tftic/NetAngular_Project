using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Services;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
//using Newtonsoft.Json;

namespace API
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
            string apiAddress = "https://localhost:44381";

            services.AddControllers()
                //.AddXmlSerializerFormatters()
                .AddNewtonsoftJson();

            /*
                https://www.youtube.com/watch?v=vlRqxCpCKGU
                https://www.youtube.com/watch?v=NSQHiIAP7Z8
                https://www.youtube.com/watch?v=tk1QK71DVtg
             */
            // Add Cors
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            // For image upload/download
            services.Configure<FormOptions>(x =>
                                               {
                                                   x.ValueLengthLimit = int.MaxValue;
                                                   x.MultipartBodyLengthLimit = int.MaxValue;
                                                   x.MemoryBufferThreshold = int.MaxValue;
                                               }
                                            );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });

            services.AddSingleton<ICountryService, CountryService>();
            services.AddSingleton<ICitiesService, CitiesService>();
            services.AddSingleton<IAddressService, AddressService>();
            services.AddSingleton<IRolesService, RolesService>();
            services.AddSingleton<IContactInfoService, ContactInfoService>();
            services.AddSingleton<IProjectCategoryService, ProjectCategoryService> ();
            services.AddSingleton<ICategoryService, CategoryService> ();
            services.AddSingleton<IFilesService, FilesService> ();
            services.AddSingleton<IProjectCategoryProductService, ProjectCategoryProductService> ();
            services.AddSingleton<ISupplierService, SupplierService> ();
            services.AddSingleton<IProductService, ProductService> ();
            services.AddSingleton<IProductCategoryService, ProductCategoryService> ();

            services.AddAuthentication(opt =>
                {
                    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options => 
                    {
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidateAudience = true,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,

                            ValidIssuer = apiAddress,
                            ValidAudience = apiAddress,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
                        };
                    })
                ;

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("MyPolicy");

            // For image locally
            // app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
