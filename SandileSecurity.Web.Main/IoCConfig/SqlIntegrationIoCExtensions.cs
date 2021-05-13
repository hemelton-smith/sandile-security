
using Microsoft.Extensions.DependencyInjection;
using SandileSecurity.Integration.Sql.Connections;
using SandileSecurity.Web.Main.Infrastructure;

namespace SandileSecurity.Web.Main.IoCConfig
{
    public static class SqlIntegrationIoCExtensions
    {
        public static IServiceCollection AddSqlIntegration(this IServiceCollection services)
        {
            services.AddScoped<IDbSettings, DbSettings>();
            services.AddScoped<ISandileSecurityDbConnectionContext>(
                provider => new AutoConnectingDbConnectionContext(provider.GetService<IDbSettings>(), settings => settings.ConnectionString)
            );

            return services;
        }
    }
}
