using Design.Patterns.Creational.Abstract_Factory.Interface;

namespace Design.Patterns.Creational.Abstract_Factory.Protoss
{
    public class BaseAbstractFactoryProtoss : IBaseAbstractFactory
    {
        public IBase Build()
        {
            var cladding = new BaseCladdingProtoss();
            var energy = new BaseEnergyProtoss();

            var result = new BasePrototype(cladding, energy);

            return result;
        }
    }
}
