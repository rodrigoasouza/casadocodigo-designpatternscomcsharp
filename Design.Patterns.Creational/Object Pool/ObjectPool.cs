using Design.Patterns.Creational.Object_Pool.Interface;
using System.Collections.Concurrent;

namespace Design.Patterns.Creational.Object_Pool
{
    public class ObjectPool<T>
    {
        public const int MaxPoolSize = 10;

        private readonly ConcurrentBag<T> _Pool;
        private readonly IObjectGenerator<T> _ObjectGenerator;
        private readonly int _MaxPoolSizeParameter;

        public ObjectPool(IObjectGenerator<T> objectGenerator, int maxSizePool = ObjectPool<T>.MaxPoolSize)
        {
            _Pool = new ConcurrentBag<T>();
            _ObjectGenerator = objectGenerator;
            _MaxPoolSizeParameter = maxSizePool;
        }

        public T Get()
        {
            if (!_Pool.TryTake(out T result))
            {
                result = _ObjectGenerator.Generate();
            }

            return result;
        }

        public void Release(T item)
        {
            if (_Pool.Count < _MaxPoolSizeParameter)
            {
                _Pool.Add(item);
            }
        }
    }
}
