using Microsoft.Extensions.DependencyInjection;
using SandileSecurity.Domain.SandileSecurity;
using SandileSecurity.Domain.SandileSecurity.UseCase;
using SandileSecurity.Integration.Sql.SandileSecurity;

namespace SandileSecurity.Web.Main.IoCConfig
{
    public static class SandileSecurityIoCExtensions
    {
        public static IServiceCollection AddSandileSecurity(this IServiceCollection services)
        {
            services.AddScoped<ISandileSecurityGateway, SandileSecurityGateway>();
            services.AddScoped<IGetAllVehiclesUseCase, GetAllVehiclesUseCase>();
            services.AddScoped<IGetAllVehiclesNearServiceUseCase, GetAllVehiclesNearServiceUseCase>();
            services.AddScoped<IGetAllVehiclesOverWarranty, GetAllVehiclesOverWarranty>();
            return services;
        }
    }
}
