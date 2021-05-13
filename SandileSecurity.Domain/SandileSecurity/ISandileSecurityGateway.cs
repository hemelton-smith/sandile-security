using System.Collections.Generic;
using System.Threading.Tasks;

namespace SandileSecurity.Domain.SandileSecurity
{
    public interface ISandileSecurityGateway
    {
        Task<List<Vehicle>> GetAllVehicles();

    }
}
