using SandileSecurity.Domain.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SandileSecurity.Domain.SandileSecurity.UseCase
{
    public class GetAllVehiclesOverWarranty : IGetAllVehiclesOverWarranty
    {
        private readonly ISandileSecurityGateway _sandileSecurityGateway;
        public GetAllVehiclesOverWarranty(ISandileSecurityGateway sandileSecurityGateway)
        {
            _sandileSecurityGateway = sandileSecurityGateway;
        }
        
        public async Task GetAllVehicles(ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> presenter)
        {
            const long maxMilleage = 90000;
            var vehicleList = await _sandileSecurityGateway.GetAllVehicles();
            List<Vehicle> vehicleListNearService = new List<Vehicle>();

            foreach (var vehicle in vehicleList)
            {
                if (vehicle.CurrentMilleage > maxMilleage || (maxMilleage - vehicle.CurrentMilleage < 5000))
                {
                    vehicleListNearService.Add(vehicle);
                }
            }

            if(vehicleListNearService.Count > 0)
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
