using Design.Patterns.Creational.Builder.Vehicle.Interface;

namespace Design.Patterns.Creational.Builder.Vehicle
{
    internal class JeepVehicle : IVehicle
    {
        public int Speed => BuilderConst.VehicleSpeedJeep;
    }
}
