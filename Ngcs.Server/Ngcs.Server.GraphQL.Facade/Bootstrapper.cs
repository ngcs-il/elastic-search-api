using LogoFX.Server.Bootstrapping;
using Microsoft.Extensions.DependencyInjection;
using Solid.Practices.Composition;

namespace Ngcs.Server.GraphQL.Facade
{
    internal sealed class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper(IServiceCollection dependencyRegistrar)
            : base(dependencyRegistrar)
        {
        }

        public override CompositionOptions CompositionOptions => new()
        {
            Prefixes = new[] { "Ngcs.ElasticSearch" }
        };
    }
}