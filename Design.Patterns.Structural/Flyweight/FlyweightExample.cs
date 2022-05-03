using Design.Patterns.Structural.Flyweight.MusicalInstrument;
using Design.Patterns.Structural.Flyweight.MusicalKey.Enum;
using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight
{
    public class FlyweightExample
    {
        public void Example()
        {
            var music = new List<IMusicalKey>()
            {
                MusicalKeyFlyweight.Get(MusicalKeys.Do),
                MusicalKeyFlyweight.Get(MusicalKeys.Re),
                MusicalKeyFlyweight.Get(MusicalKeys.Mi),
                MusicalKeyFlyweight.Get(MusicalKeys.Fa),
                MusicalKeyFlyweight.Get(MusicalKeys.Fa),
                MusicalKeyFlyweight.Get(MusicalKeys.Fa),
            };

            var guitar = new Guitar();
            guitar.Play(music);
        }
    }
}