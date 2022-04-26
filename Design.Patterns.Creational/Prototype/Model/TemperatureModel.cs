using Design.Patterns.Creational.Prototype.Enums;
using Design.Patterns.Creational.Prototype.Interface;

namespace Design.Patterns.Creational.Prototype.Model
{
    public class TemperatureModel : ITemperature
    {
        public TemperatureModel()
        {

        }

        public TemperatureModel(ITemperature temperature)
        {
            Scale = temperature.Scale;
            Temperature = temperature.Temperature;
        }

        public ScaleOfTemperature Scale { get; set; }
        public double Temperature { get; set; }
    }
}
