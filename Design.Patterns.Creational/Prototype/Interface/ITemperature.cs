using Design.Patterns.Creational.Prototype.Enums;

namespace Design.Patterns.Creational.Prototype.Interface
{
    public interface ITemperature
    {
        ScaleOfTemperature Scale { get; set; }
        double Temperature { get; set; }
    }
}
