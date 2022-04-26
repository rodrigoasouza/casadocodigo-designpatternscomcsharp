using Design.Patterns.Creational.Builder.Vehicle.Interface;

namespace Design.Patterns.Creational.Builder.Vehicle
{
    public class HelicopterVehicle : IVehicle
    {
        public int Speed => BuilderConst.VehicleSpeedHelicopter;
    }
}
