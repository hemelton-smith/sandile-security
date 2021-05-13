using FluentMigrator;

namespace SandileSecurity.Integration.Sql.Migrations
{
    [Migration(202104281143)]
    public class M03_InsertMoreVehicles : Migration
    {
        public override void Down()
        {
            throw new System.NotImplementedException();
        }

        public override void Up()
        {
            Insert.IntoTable("Vehicle")
             .Row(new { Id = "25846766-478d-4b07-811f-604a2c94a000", RegistrationNumber = "NUR 1274", Make = "Toyota", Model = "Hylux", ServiceInterval = 15000, CurrentMilleage = 89000, TankCapacity = 80, NumberOfTyres = 4 })
             .Row(new { Id = "1232e854-1d3c-4c31-9ec4-55efa49e7111", RegistrationNumber = "NUZ 1001", Make = "Nissan", Model = "NP 200", ServiceInterval = 15000, CurrentMilleage = 88100, TankCapacity = 50, NumberOfTyres = 4 });


        }
    }
}
