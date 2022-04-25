using Design.Patterns.Creational.Abstract_Factory.Interface;

namespace Design.Patterns.Creational.Abstract_Factory.Protoss
{
    public class BaseCladdingProtoss : ICladding
    {
        public string Color => AbstractFactoryConst.ColorProtoss;
    }
}
