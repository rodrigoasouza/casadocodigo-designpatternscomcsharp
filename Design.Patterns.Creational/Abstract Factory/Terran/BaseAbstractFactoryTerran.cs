using Design.Patterns.Creational.Abstract_Factory.Interface;

namespace Design.Patterns.Creational.Abstract_Factory.Terran
{
    public class BaseAbstractFactoryTerran : IBaseAbstractFactory
    {
        public IBase Build()
        {
            var cladding = new BaseCladdingTerran();
            var energy = new BaseEnergyTerran();

            var result = new BasePrototype(cladding, energy);

            return result;
        }
    }
}
