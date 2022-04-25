using Design.Patterns.Creational.Abstract_Factory.Interface;

namespace Design.Patterns.Creational.Abstract_Factory.Zerg
{
    public class BaseCladdingZerg : ICladding
    {
        public string Color => AbstractFactoryConst.ColorZerg;
    }
}
