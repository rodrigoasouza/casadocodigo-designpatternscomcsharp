namespace Design.Patterns.Creational.Object_Pool.Interface
{
    public interface IObjectGenerator<out T>
    {
        T Generate();
    }
}
