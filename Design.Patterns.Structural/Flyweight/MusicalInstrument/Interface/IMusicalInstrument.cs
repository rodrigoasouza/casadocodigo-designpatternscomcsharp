using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight.MusicalInstrument.Interface
{
    public interface IMusicalInstrument
    {
        public void Play(IList<IMusicalKey> music);
    }
}
