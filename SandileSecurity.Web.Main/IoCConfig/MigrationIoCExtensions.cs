using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using SandileSecurity.Integration.Sql.Connections;
using SandileSecurity.Integration.Sql.Migrations;
using System;

namespace SandileSecurity.Web.Main.IoCConfig
{
    public static class MigrationIoCExtensions
    {
        public static IServiceCollection AddMigrations(this IServiceCollection services)
        {
            services.AddTransient(provider =>
            {
                var dbSettings = provider.GetService<IDbSettings>();
                var serviceProvider = (IServiceProvider)new ServiceCollection()
                    .AddFluentMigratorCore()
                    .ConfigureRunner(rb => rb
                        .AddSqlServer()
                        .WithGlobalConnectionString(dbSettings.ConnectionString)
                        .ScanIn(typeof(IMigrationMarker).Assembly)
                        .For
                        .All()
                    )
                    .AddLogging(lb => lb.AddFluentMigratorConsole())
                    .BuildServiceProvider(false);

                return serviceProvider
                    .GetRequiredService<IMigrationRunner>();
            });

            return services;
        }
    }
}
