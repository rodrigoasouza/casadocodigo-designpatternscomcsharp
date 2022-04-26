using Design.Patterns.Creational.Prototype.Enums;

namespace Design.Patterns.Creational.Prototype.Interface
{
    public interface IClimate
    {
        Weather Weather { get; set; }

        ITemperature Temperature { get; set; }
    }
}
