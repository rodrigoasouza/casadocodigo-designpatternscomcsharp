using Design.Patterns.Structural.Adapter.Interface;

namespace Design.Patterns.Structural.Adapter
{
    internal class Character : IAction
    {
        public void Shoot()
        {
            Console.WriteLine("Your code to take a shot");
        }

        public void Walk()
        {
            Console.WriteLine("Your code to walk");
        }
    }
}
