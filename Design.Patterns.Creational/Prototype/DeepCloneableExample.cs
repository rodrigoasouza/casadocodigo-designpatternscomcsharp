using Design.Patterns.Creational.Prototype.Cloneable;
using Design.Patterns.Creational.Prototype.Interface;
using Design.Patterns.Creational.Prototype.Model;

namespace Design.Patterns.Creational.Prototype
{
    public class DeepCloneableExample :
        ClimateBase,
        IDeepCloneable<IClimate>
    {
        public DeepCloneableExample()
        {
        }

        public DeepCloneableExample(IClimate climate)
        {
            Weather = climate.Weather;

            if (climate.Temperature != null)
            {
                Temperature = new TemperatureModel(climate.Temperature);
            }
        }

        public object Clone() =>
            MemberwiseClone();

        public IClimate DeepClone() =>
            new DeepCloneableExample(this);
    }
}
