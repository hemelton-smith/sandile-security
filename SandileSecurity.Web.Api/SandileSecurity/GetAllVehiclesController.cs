using Microsoft.AspNetCore.Mvc;
using SandileSecurity.Domain.Output;
using SandileSecurity.Domain.SandileSecurity;
using SandileSecurity.Domain.SandileSecurity.UseCase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SandileSecurity.Web.Api.SandileSecurity
{
    [ApiController]
    [Route("getallvehicles")]
    public class GetAllVehiclesController : ControllerBase
    {
        private readonly IGetAllVehiclesUseCase _getAllVehiclesUseCase;
        private readonly ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> _presenter;

        public GetAllVehiclesController(IGetAllVehiclesUseCase getAllVehiclesUseCase,
            ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> presenter)
        {
            _getAllVehiclesUseCase = getAllVehiclesUseCase;
            _presenter = presenter;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllVehicles()
        {
             await _getAllVehiclesUseCase.GetAllVehicles(_presenter);
            return _presenter.Render();
        }
    }
}
