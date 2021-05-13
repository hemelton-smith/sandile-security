using System;

namespace SandileSecurity.Domain.SandileSecurity
{
    public class Vehicle
    {
        public Guid id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ServiceInterval { get; set; }
        public long CurrentMilleage { get; set; }
        public decimal TankCapacity { get; set; }
        public int NumberOfTyres { get; set; }
    }
}
