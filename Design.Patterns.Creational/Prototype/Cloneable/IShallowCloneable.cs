namespace Design.Patterns.Creational.Prototype.Cloneable
{
    public interface IShallowCloneable<out T> : ICloneable
    {
        T ShallowClone();
    }
}
