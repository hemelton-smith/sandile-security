using Microsoft.AspNetCore.Mvc;
using SandileSecurity.Domain.Output;
using SandileSecurity.Domain.SandileSecurity;
using SandileSecurity.Domain.SandileSecurity.UseCase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SandileSecurity.Web.Api.SandileSecurity
{
    [ApiController]
    [Route("vehiclesnearservice")]
    public class GetVehiclesNearServiceController : ControllerBase
    {
        private readonly IGetAllVehiclesNearServiceUseCase _getAllVehiclesNearServiceUseCase;
        private readonly ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> _presenter;
        public GetVehiclesNearServiceController(IGetAllVehiclesNearServiceUseCase getAllVehiclesNearServiceUseCase,
            ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> presenter)
        {
            _getAllVehiclesNearServiceUseCase = getAllVehiclesNearServiceUseCase;
            _presenter = presenter;
        }

        [HttpGet]

        public async Task<IActionResult> GetVehiclesNearService()
        {
             await _getAllVehiclesNearServiceUseCase.GetAllVehiclesNearService(_presenter);
            return _presenter.Render();
        }

    }
}
