using Design.Patterns.Creational.Abstract_Factory.Interface;

namespace Design.Patterns.Creational.Abstract_Factory.Terran
{
    public class BaseCladdingTerran : ICladding
    {
        public string Color => AbstractFactoryConst.ColorTerran;
    }
}
