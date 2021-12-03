using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BaskislaAPI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using Repository;
using Entities;
using Microsoft.OpenApi.Models;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using BaskislaAPI.Factory;
using EmailService;

namespace BaskislaAPI
{

    public class Startup
    {
        private readonly IWebHostEnvironment _env;

        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
            _env = env;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            services.ConfigureCors();
            services.ConfigureIISIntegration();

            services.ConfigureLoggerService();
            //services.ConfigureMySqlContext(Configuration);

            //if(!_env.IsDevelopment())
            //    services.AddDbContext<RepositoryContext>(option => option.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
            //else
                services.AddDbContext<RepositoryContext>(option => option.UseSqlServer(Configuration.GetConnectionString("database")));

            //Add identity
            services.AddIdentity<User, IdentityRole>( opt =>
            {
                opt.Password.RequiredLength = 7;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;

                opt.User.RequireUniqueEmail = true;
                opt.SignIn.RequireConfirmedEmail = true;

            })
                .AddEntityFrameworkStores<RepositoryContext>()
                .AddDefaultTokenProviders();

            services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(2));


            services.AddScoped<IUserClaimsPrincipalFactory<User>, CustomClaimsFactory>();

            var emailConfig = Configuration
                .GetSection("EmailConfiguration")
                .Get<EmailConfiguration>();

            services.AddSingleton(emailConfig);
            services.AddScoped<IEmailSender, EmailSender>();




            services.AddSwaggerGen( c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "swagger for baskisla", Version = "v1" });
            });

            services.ConfigureRepositoryWrapper();

            services.AddControllers();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCors("CorsPolicy");

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
