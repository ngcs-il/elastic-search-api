using System.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ngcs.Data.AdoDotNet.DbContext;
using Ngcs.Data.AdoDotNet.Repository;
using Ngcs.Data.Repository;
using Ngcs.ElasticSearch.Data.AdoDotNet.Context;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSearch.Domain.Implementation.Services;

namespace Ngcs.Server.GraphQL.Facade
{
	public class Startup
	{
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

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
            var connectionString = configuration.GetConnectionString("appEntities");
			AddConnectionString("appEntities", connectionString);
        }

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<ICourtsService, CourtsService>()
					.AddSingleton<IUnitOfWork, UnitOfWork>()
					.AddSingleton<IDbContext, AppDbContext>()
					.AddTransient<ITransactionFactory, TransactionConcreteFactory>()
					.AddTransient<IDbContextFactory, DbContextFactory>()
					//.AddScoped<Query>()
					.AddGraphQLServer()
					.AddQueryType<Query>();
			services.AddRazorPages();
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
				;
		}
	}
}
