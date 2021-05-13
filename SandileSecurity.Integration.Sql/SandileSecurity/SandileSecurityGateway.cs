using Dapper;
using SandileSecurity.Domain.SandileSecurity;
using SandileSecurity.Integration.Sql.Connections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SandileSecurity.Integration.Sql.SandileSecurity
{
    public class SandileSecurityGateway : ISandileSecurityGateway
    {
        private readonly ISandileSecurityDbConnectionContext _context;
        private IDbTransaction DbTransaction => _context.GetTransaction();
        private IDbConnection DbConnection => _context.GetConnection();

        public SandileSecurityGateway(ISandileSecurityDbConnectionContext context)
        {
            _context = context;
        }
        public async Task<List<Vehicle>> GetAllVehicles()
        {
            var vehicles = await DbConnection.QueryAsync<Vehicle>(@"SELECT [Id]
                                                                  ,[RegistrationNumber]
                                                                  ,[Make]
                                                                  ,[Model]
                                                                  ,[ServiceInterval]
                                                                  ,[CurrentMilleage]
                                                                  ,[TankCapacity]
                                                                  ,[NumberOfTyres]
                                                              FROM [dbo].[Vehicle] ORDER BY [Make], [Model]", null, DbTransaction);
            return vehicles.AsList<Vehicle>();
        }
    }
}
