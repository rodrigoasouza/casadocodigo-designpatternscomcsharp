using Design.Patterns.Creational.Abstract_Factory.Interface;

namespace Design.Patterns.Creational.Abstract_Factory
{
    public class BasePrototype : IBase
    {
        public BasePrototype(ICladding cladding, IEnergy energy)
        {
            Cladding = cladding;
            Energy = energy;
        }

        public ICladding Cladding { get; }
        public IEnergy Energy { get; }
    }
}
