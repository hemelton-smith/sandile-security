using System.Data;

namespace SandileSecurity.Integration.Sql.Connections
{
    public interface IDbConnectionContext
    {
        IDbConnection GetConnection();
        IDbTransaction GetTransaction();
        void Commit();
        void Rollback();
    }
}
