using Design.Patterns.Structural.Adapter.Interface;

namespace Design.Patterns.Structural.Adapter
{
    public class Adapter : IAction
    {
        private readonly Warplane _Warplane;

        public Adapter(Warplane warplane)
        {
            _Warplane = warplane;
        }

        public void Shoot()
        {
            _Warplane.Shoot();
        }

        public void Walk()
        {
            _Warplane.ToFly();
        }
    }
}
