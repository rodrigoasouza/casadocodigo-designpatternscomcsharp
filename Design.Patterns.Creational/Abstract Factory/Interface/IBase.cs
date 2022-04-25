namespace Design.Patterns.Creational.Abstract_Factory.Interface
{
    public interface IBase
    {
        ICladding Cladding { get; }
        IEnergy Energy { get; }
    }
}
