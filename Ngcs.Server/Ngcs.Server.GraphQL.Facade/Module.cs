﻿using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Solid.Practices.Modularity;

namespace Ngcs.Server.GraphQL.Facade
{
    [UsedImplicitly]
    internal sealed class Module : ICompositionModule<IServiceCollection>
    {
        public void RegisterModule(IServiceCollection dependencyRegistrator) => dependencyRegistrator.AddCors(options =>
                options.AddPolicy("AllowAny",
                    builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()))
            .AddMvc()
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
    }
}