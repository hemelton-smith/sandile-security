using SandileSecurity.Domain.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SandileSecurity.Domain.SandileSecurity.UseCase
{
    public class GetAllVehiclesNearServiceUseCase : IGetAllVehiclesNearServiceUseCase
    {
        private readonly ISandileSecurityGateway _sandileSecurityGateway;

        public GetAllVehiclesNearServiceUseCase(ISandileSecurityGateway sandileSecurityGateway)
        {
            _sandileSecurityGateway = sandileSecurityGateway;
        }

        public async Task<List<Vehicle>> GetAllVehiclesNearService()
        {
            const long maxMilleage = 90000;
            var vehicleList = await _sandileSecurityGateway.GetAllVehicles();
            List<Vehicle> vehicleListNearService = new List<Vehicle>();

            foreach (var vehicle in vehicleList)
            {
                if (!(vehicle.CurrentMilleage > maxMilleage) && ((maxMilleage - vehicle.CurrentMilleage) < 2000))
                {
                    vehicleListNearService.Add(vehicle);
                }
            }

            return vehicleListNearService;
        }

        public async Task GetAllVehiclesNearService(ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> presenter)
        {
            const long maxMilleage = 90000;
            var vehicleList = await _sandileSecurityGateway.GetAllVehicles();
            List<Vehicle> vehicleListNearService = new List<Vehicle>();

            foreach (var vehicle in vehicleList)
            {
                if (!(vehicle.CurrentMilleage > maxMilleage) && ((maxMilleage - vehicle.CurrentMilleage) < 2000))
                {
                    vehicleListNearService.Add(vehicle);
                }
            }

            if (vehicleListNearService.Count > 0)
            {
                presenter.Success(vehicleListNearService);
            }
            else
            {
                presenter.Error(new ErrorDto
                {
                    Message = "No vehicles near service found"
                });
            }
        }
    }
}
