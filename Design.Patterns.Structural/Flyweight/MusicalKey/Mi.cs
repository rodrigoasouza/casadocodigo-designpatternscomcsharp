using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight.MusicalKey
{
    public class Mi : IMusicalKey
    {
        public int Frequency
        {
            get => FlyweightConst.FrequencyMi;
        }
    }
}
