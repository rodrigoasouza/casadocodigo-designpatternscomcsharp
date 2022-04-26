using Design.Patterns.Creational.Prototype.Enums;
using Design.Patterns.Creational.Prototype.Interface;

namespace Design.Patterns.Creational.Prototype
{
    public abstract class ClimateBase : IClimate
    {
        public Weather Weather { get; set; }
        public ITemperature Temperature { get; set; }
    }
}
