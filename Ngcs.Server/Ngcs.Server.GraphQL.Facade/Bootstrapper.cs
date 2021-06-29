using LogoFX.Server.Bootstrapping;
using Microsoft.Extensions.DependencyInjection;
using Solid.Practices.Composition;

namespace Ngcs.Server.GraphQL.Facade
{
    internal sealed class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper(IServiceCollection dependencyRegistrator) 
            : base(dependencyRegistrator)
        {
        }

        public override CompositionOptions CompositionOptions => new CompositionOptions
        {
            Prefixes = new[] { "Ngcs.ElasticSearch" }
        };
    }
}