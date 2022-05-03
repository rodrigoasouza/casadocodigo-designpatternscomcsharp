using Design.Patterns.Structural.Flyweight.MusicalInstrument.Interface;
using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight.MusicalInstrument
{
    public class Guitar : IMusicalInstrument
    {
        public const int FrequencyDuration = 175;

        public void Play(IList<IMusicalKey> music)
        {
            foreach (var item in music)
            {
                Console.Beep(item.Frequency, FrequencyDuration);
            }
        }
    }
}
