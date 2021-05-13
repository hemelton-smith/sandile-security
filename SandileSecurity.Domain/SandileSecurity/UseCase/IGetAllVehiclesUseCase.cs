using SandileSecurity.Domain.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SandileSecurity.Domain.SandileSecurity.UseCase
{
    public interface IGetAllVehiclesUseCase
    {
        Task GetAllVehicles(ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> presenter);
    }
}
