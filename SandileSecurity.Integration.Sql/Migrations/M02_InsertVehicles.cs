using FluentMigrator;

namespace SandileSecurity.Integration.Sql.Migrations
{
    [Migration(202104272152)]
    public class M02_InsertVehicles : Migration
    {
        public override void Down()
        {
            throw new System.NotImplementedException();
        }

        public override void Up()
        {
            Insert.IntoTable("Vehicle")
                .Row(new { Id = "02546766-478d-4b07-811f-604a2c94a936", RegistrationNumber = "NUR 1278", Make = "Toyota", Model = "Hylux", ServiceInterval = 15000, CurrentMilleage = 188200, TankCapacity = 80, NumberOfTyres = 4 })
                .Row(new { Id = "0932e854-1d3c-4c31-9ec4-55efa49e71e1", RegistrationNumber = "NUZ 1000", Make = "Nissan", Model = "NP 200", ServiceInterval = 15000, CurrentMilleage = 28250, TankCapacity = 50, NumberOfTyres = 4 })
                .Row(new { Id = "f314a69a-4803-4d25-97e7-eee4baf03205", RegistrationNumber = "NJ 256678", Make = "Nissan", Model = "NP 300", ServiceInterval = 15000, CurrentMilleage = 14250, TankCapacity = 50, NumberOfTyres = 4 })
                .Row(new { Id = "1ab42d50-2ecc-4dda-a1f9-38ee9b5b020d", RegistrationNumber = "NUR 1692", Make = "Toyota", Model = "Atios", ServiceInterval = 15000, CurrentMilleage = 66002, TankCapacity = 45, NumberOfTyres = 4 })
                .Row(new { Id = "ebb5be17-ec2e-4b7c-a919-f80ca4dece9b", RegistrationNumber = "NUR 16998", Make = "Volvo", Model = "ET200", ServiceInterval = 20000, CurrentMilleage = 25069, TankCapacity = 300, NumberOfTyres = 24 })
                .Row(new { Id = "b1e2a664-89e3-4897-8611-5211db19bfce", RegistrationNumber = "NUR 6987", Make = "Scania", Model = "E500", ServiceInterval = 25000, CurrentMilleage = 87026, TankCapacity = 320, NumberOfTyres = 24 })
                .Row(new { Id = "1236650d-3e9f-4a6a-a3bd-e06d6e6efa1d", RegistrationNumber = "NUR 66932", Make = "Mercedes", Model = "LP200", ServiceInterval = 20000, CurrentMilleage = 118639, TankCapacity = 300, NumberOfTyres = 18 })
                .Row(new { Id = "b31c7607-c3ce-41d5-a2e5-4bef55ed1f55", RegistrationNumber = "NUR 89654", Make = "Scania", Model = "E698", ServiceInterval = 25000, CurrentMilleage = 58796, TankCapacity = 300, NumberOfTyres = 24 })
                .Row(new { Id = "af51820d-fe15-4637-b8cd-f76fe94fc680", RegistrationNumber = "NUR 3698", Make = "Toyota", Model = "Tazz", ServiceInterval = 15000, CurrentMilleage = 350698, TankCapacity = 50, NumberOfTyres = 4 })
                .Row(new { Id = "01f7b684-4ac3-4d25-b1df-51a709b2d70d", RegistrationNumber = "NUR 3217", Make = "Nissan", Model = "Hardbody", ServiceInterval = 15000, CurrentMilleage = 66584, TankCapacity = 50, NumberOfTyres = 4 })
                .Row(new { Id = "6a97a163-70f5-486a-ab81-261f70662b1f", RegistrationNumber = "NUR 14789", Make = "Toyota", Model = "Hylux", ServiceInterval = 15000, CurrentMilleage = 13600, TankCapacity = 50, NumberOfTyres = 4 })
                .Row(new { Id = "cd8bed51-0dec-4b59-8e80-232216436ba8", RegistrationNumber = "NUR 258963", Make = "Volvo", Model = "ET300", ServiceInterval = 20000, CurrentMilleage = 280250, TankCapacity = 350, NumberOfTyres = 24 });
        }
    }
}
