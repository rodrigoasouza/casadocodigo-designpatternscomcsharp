using System.ComponentModel;

namespace Design.Patterns.Creational.Prototype.Enums
{
    public enum ScaleOfTemperature
    {
        [Description]
        Null = 0,
        
        [Description("K")]
        Kelvin = 1,

        [Description("°C")]
        Celsius = 2,

        [Description("°F")]
        Fahrenheit = 3,

        [Description("°Ra")]
        Rankine = 4,

        [Description("°R")]
        Romer = 5,

        [Description("°N")]
        Newton = 6,

        [Description("°De")]
        Delisle = 7,

        [Description("°Ré")]
        Reaumur = 8,
    }
}
