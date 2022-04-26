using Design.Patterns.Creational.Prototype.Cloneable;
using Design.Patterns.Creational.Prototype.Interface;

namespace Design.Patterns.Creational.Prototype
{
    public class ShallowCloneableExample :
        ClimateBase,
        IShallowCloneable<IClimate>
    {
        public object Clone() =>
            MemberwiseClone();

        public IClimate ShallowClone() =>
            (ShallowCloneableExample)Clone();
    }
}
