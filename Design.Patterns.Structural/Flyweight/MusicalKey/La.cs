using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight.MusicalKey
{
    public class La : IMusicalKey
    {
        public int Frequency
        {
            get => FlyweightConst.FrequencyLa;
        }
    }
}
