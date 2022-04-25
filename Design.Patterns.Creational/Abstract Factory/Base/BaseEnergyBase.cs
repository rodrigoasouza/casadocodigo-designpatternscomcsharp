namespace Design.Patterns.Creational.Abstract_Factory.Base
{
    public abstract class BaseEnergyBase : IEnergy
    {
        public decimal StartEnergy = 1000M;

        public virtual decimal Current => _Current;
        public virtual decimal Start => StartEnergy;

        internal decimal _Current { get; set; }
    }
}
