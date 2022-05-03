using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight.MusicalKey
{
    public class Do : IMusicalKey
    {
        public int Frequency
        {
            get => FlyweightConst.FrequencyDo;
        }
    }
}
