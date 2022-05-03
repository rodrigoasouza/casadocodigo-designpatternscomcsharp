using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight.MusicalKey
{
    public class Sol : IMusicalKey
    {
        public int Frequency
        {
            get => FlyweightConst.FrequencySol;
        }
    }
}
