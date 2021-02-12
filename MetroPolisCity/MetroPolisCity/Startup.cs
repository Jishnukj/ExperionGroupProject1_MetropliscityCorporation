using MetroPolisBusinessService;
using MetroPolisDataService;
using MetroPolisDataService.Repo;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Cors;

namespace MetroPolisCity
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
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<IStreetService, StreetService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IActivityRepo, ActivityRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IStreetRepo, StreetRepo>();
            services.AddCors(options =>
            {

                var origins = "http://localhost:4200";
                options.AddPolicy("CorsPolicy", builder => builder
                .WithOrigins(origins)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            });
            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
            //    .AllowAnyHeader()
            //    .AllowCredentials());
            //});

            //authentication
            var key = Encoding.UTF8.GetBytes("123433231324354343434");

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = false;
                x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            });

            services.AddDbContext<ApplicationDbContext>(
                   options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MetroDb;Trusted_Connection=True;"));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MetroPolisCity", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MetroPolisCity v1"));
            }

            app.UseHttpsRedirection();


            app.UseRouting();

            app.UseAuthorization();
            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
