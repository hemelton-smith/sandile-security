using SandileSecurity.Domain.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SandileSecurity.Domain.SandileSecurity.UseCase
{
    public class GetAllVehiclesUseCase : IGetAllVehiclesUseCase
    {
        private readonly ISandileSecurityGateway _sandileSecurityGateway;

        public GetAllVehiclesUseCase(ISandileSecurityGateway sandileSecurityGateway)
        {
            _sandileSecurityGateway = sandileSecurityGateway;
        }

        public async Task GetAllVehicles(ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> presenter)
        {
            var vehicles = await _sandileSecurityGateway.GetAllVehicles();

            if(vehicles.Count > 0)
            {
                presenter.Success(vehicles);
            }
            else
            {
                presenter.Error(new ErrorDto
                {
                    Message = "No vehicles found"
                });
            }
        }
    }
}
