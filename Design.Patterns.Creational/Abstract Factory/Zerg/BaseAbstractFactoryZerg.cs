using Design.Patterns.Creational.Abstract_Factory.Interface;

namespace Design.Patterns.Creational.Abstract_Factory.Zerg
{
    internal class BaseAbstractFactoryZerg : IBaseAbstractFactory
    {
        public IBase Build()
        {
            var cladding = new BaseCladdingZerg();
            var energy = new BaseEnergyZerg();

            var result = new BasePrototype(cladding, energy);

            return result;
        }
    }
}
