using FluentMigrator;

namespace SandileSecurity.Integration.Sql.Migrations
{
    [Migration(202104272056)]
    public class M01_CreateVehiclesTable : Migration
    {
        public override void Down()
        {
            throw new System.NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("Vehicle")
                .WithColumn("Id").AsGuid().PrimaryKey("PK_VehicleId")
                .WithColumn("RegistrationNumber").AsString(10)
                .WithColumn("Make").AsString(10)
                .WithColumn("Model").AsString(10)
                .WithColumn("ServiceInterval").AsInt32()
                .WithColumn("CurrentMilleage").AsInt64()
                .WithColumn("TankCapacity").AsDecimal()
                .WithColumn("NumberOfTyres").AsInt32();

        }
    }
}
