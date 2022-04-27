using Design.Patterns.Creational.Object_Pool.Interface;

namespace Design.Patterns.Creational.Object_Pool
{
    public class ObjectPoolExample
    {
        public class RandomObjectGenerator : IObjectGenerator<Random>
        {
            public Random Generate() =>
                new Random(1);
        }

        private readonly ObjectPool<Random> _Pool = new(new RandomObjectGenerator());

        public void Example()
        {
            for (int i = 0; i < 100; i++)
            {
                var item = _Pool.Get();
                
                /*
                    YOUR CODE
                */

                _Pool.Release(item);
            }
        }
    }
}
