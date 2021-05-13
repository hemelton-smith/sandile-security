using Microsoft.Extensions.DependencyInjection;
using SandileSecurity.Domain.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandileSecurity.Web.Main.IoCConfig
{
    public static class PresenterIoCExtensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped(typeof(ISuccessOrErrorActionResultPresenter<,>), typeof(SuccessOrErrorRestPresenter<,>));
            services.AddScoped(typeof(IErrorActionResultPresenter<>), typeof(ErrorRestPresenter<>));

            return services;
        }
    }
}
