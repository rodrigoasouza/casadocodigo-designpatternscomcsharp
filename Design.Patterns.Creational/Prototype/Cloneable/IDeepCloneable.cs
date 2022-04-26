namespace Design.Patterns.Creational.Prototype.Cloneable
{
    public interface IDeepCloneable<out T> : ICloneable
    {
        T DeepClone();
    }
}
