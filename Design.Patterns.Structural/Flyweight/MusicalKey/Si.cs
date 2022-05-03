using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight.MusicalKey
{
    public class Si : IMusicalKey
    {
        public int Frequency
        {
            get => FlyweightConst.FrequencyLa;
        }
    }
}
