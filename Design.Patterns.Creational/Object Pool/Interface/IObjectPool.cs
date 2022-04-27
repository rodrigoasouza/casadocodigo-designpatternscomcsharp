namespace Design.Patterns.Creational.Object_Pool.Interface
{
    public interface IObjectPool<T>
    {
        void Release(T item);
        T Get();
    }
}
