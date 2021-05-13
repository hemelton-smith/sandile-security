﻿using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using SandileSecurity.Integration.Sql.Migrations;
using System;

namespace SandileSecurity.Integration.Sql.Infrastructure
{
    public class MigrationRunner
    {
        public void Migrate(string connectionString)
        {
            var serviceProvider = (IServiceProvider)new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(typeof(IMigrationMarker).Assembly)
                    .For
                    .All()
                )
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);

            using var scope = serviceProvider.CreateScope();
            scope.ServiceProvider
                .GetRequiredService<IMigrationRunner>()
                .MigrateUp();
        }
    }
}
