using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ngcs.Data.DbContext.AdoDotNet;
using Ngcs.Data.Repository;
using Ngcs.Data.Repository.AdoDotNet;
using Ngcs.ElasticSearch.Data.Context.AdoDotNet;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSearch.Domain.Implementation.Services;

namespace Ngcs.Server.GraphQL.Facade
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")] 
        public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<ICourtsService, CourtsService>()
					.AddSingleton<IUnitOfWork, UnitOfWork>()
					.AddSingleton<IDbContext, AppDbContext>()
					.AddTransient<ITransactionFactory, TransactionConcreteFactory>()
					.AddTransient<IDbContextFactory, DbContextFactory>()
                    .AddSingleton<IConnectionStringService, ConnectionStringService>()
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
		}
	}
}
