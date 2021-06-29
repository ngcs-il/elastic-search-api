using System.Configuration;
using JetBrains.Annotations;
using LogoFX.Server.Bootstrapping.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Solid.Bootstrapping;
using BootstrapperBase = LogoFX.Server.Bootstrapping.BootstrapperBase;

namespace Ngcs.Server.GraphQL.Facade
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
            var connectionString = configuration.GetConnectionString("appEntities");
			AddConnectionString("appEntities", connectionString);
        }

        [UsedImplicitly]
		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services/*.AddSingleton<ICourtsService, CourtsService>()
					.AddSingleton<IUnitOfWork, UnitOfWork>()
					.AddSingleton<IDbContext, AppDbContext>()
					.AddTransient<ITransactionFactory, TransactionConcreteFactory>()
					.AddTransient<IDbContextFactory, DbContextFactory>()*/
					.AddGraphQLServer()
					.AddQueryType<Query>();
			services.AddRazorPages();

            var bootstrapper = new Bootstrapper(services)
                .Use(new RegisterCustomCompositionModulesMiddleware<BootstrapperBase, IServiceCollection>())
                .Use(new RegisterCoreMiddleware<BootstrapperBase>())
                .Use(new RegisterControllersMiddleware<BootstrapperBase>());
            bootstrapper.Initialize();
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
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles()
				.UseRouting()
				.UseAuthorization()
				.UseEndpoints(endpoints =>
					{
						endpoints.MapRazorPages();
					})
				.UseEndpoints(endpoints =>
				{
					endpoints.MapGraphQL();
				});
		}

        private static void AddConnectionString(string name, string connectionString)
        {
            // Get the application configuration file.
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Get the conectionStrings section.
            var csSection = config.ConnectionStrings;

            //Create your connection string into a connectionStringSettings object
            var connection = new ConnectionStringSettings(name, connectionString);

            //Add the object to the configuration
            csSection.ConnectionStrings.Add(connection);

            //Save the configuration
            config.Save(ConfigurationSaveMode.Modified);

            //Refresh the Section
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
