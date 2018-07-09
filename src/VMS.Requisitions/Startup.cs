namespace VMS.Requisitions
{
    using System;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Authorization;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    using VMS.Domain;
    using VMS.Domain.EntityFramework;
    using VMS.Domain.EntityFramework.DomainProcessEventStore;
    using VMS.Extensions.AspNetCore.Filters;
    using VMS.Requisitions.Services;
    using VMS.Shared.Logging;

    public class Startup
    {
        /// <summary>
        /// The configuration.
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger logger;


        /// <summary>
        /// The logger factory.
        /// </summary>
        private readonly ILoggerFactory loggerFactory;

        public Startup(IConfiguration configuration, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            try
            {
                this.configuration = configuration;
                this.loggerFactory = loggerFactory;
                this.logger = this.loggerFactory.CreateLogger<Startup>();

                if (env.IsDevelopment())
                {
                    this.logger.AddAsciiArtLogo();
                }
                else
                {
                    this.logger.LogInformation(LoggingEvents.SYSTEM_STARTUP, "VMS Requisitons");
                }
            }
            catch (Exception ex)
            {
                this.logger.LogCritical(LoggingEvents.SYSTEM_STARTUP_ERROR, $"Startup ERROR: {ex}");
                Environment.Exit(187);
            }

        }


        // This method gets called by the runtime. Use this method to add services to the container.
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            public void ConfigureServices(IServiceCollection services)
        {
            // Register configuration and configuration root.
            services.AddSingleton(this.configuration);
            
            // Register all custom configuration options.
            services.AddInjectableCustomOptions(this.configuration);

            // Register all required DbContexts.
            services.AddDbContexts(this.configuration);

            // Register the services
            services.AddTransient<IRequisitionService, RequisitionService>();

            //// Add framework services.
            services.AddMvc(
                options =>
                    {
                        //// Mark ALL controller actions with Authorize attribute via policy...
                        //var authPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                        //options.Filters.Add(new AuthorizeFilter(authPolicy));

                        //// Setup FluentValidation as model validator...
                        //options.Filters.Add(typeof(ModelValidationToFluentValidationFilter));
                    });

            // Add Swagger documentation generation
            services.AddSwaggerGeneration(this.configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            try
            {
                // TODO: VMS.Extensions.AspNet.Core has to be upgraded to 2.1 version
                //app.UseGlobalExceptionHandler();

                app.UseCors(
                    config =>
                        config.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .WithExposedHeaders("Location")
                            .SetPreflightMaxAge(TimeSpan.FromSeconds(300)));

                //app.UseIdentityServerAuthentication(this.configuration);
                app.UseMvc();
                //app.UseSwaggerWeb(this.configuration);
            }
            catch (Exception cex)
            {
                this.logger.LogCritical(LoggingEvents.SYSTEM_STARTUP_ERROR, $"Startup.Configure ERROR: {cex}");
                Environment.Exit(187);
            }
        }
    }
}