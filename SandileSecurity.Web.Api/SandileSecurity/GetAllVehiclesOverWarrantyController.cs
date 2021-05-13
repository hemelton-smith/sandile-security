using Microsoft.AspNetCore.Mvc;
using SandileSecurity.Domain.Output;
using SandileSecurity.Domain.SandileSecurity;
using SandileSecurity.Domain.SandileSecurity.UseCase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SandileSecurity.Web.Api.SandileSecurity
{
    [ApiController]
    [Route("getvehicleaoverwarranty")]
    public class GetAllVehiclesOverWarrantyController : ControllerBase
    {
        private readonly IGetAllVehiclesOverWarranty _getAllVehiclesOverWarranty;
        private readonly ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> _presenter;
        public GetAllVehiclesOverWarrantyController(IGetAllVehiclesOverWarranty getAllVehiclesOverWarranty,
            ISuccessOrErrorActionResultPresenter<List<Vehicle>, ErrorDto> presenter)
        {
            _getAllVehiclesOverWarranty = getAllVehiclesOverWarranty;
            _presenter = presenter;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVehiclesOverWarranty()
        {
            await _getAllVehiclesOverWarranty.GetAllVehicles(_presenter);
            return _presenter.Render();
        }
    }
}
