using Design.Patterns.Structural.Flyweight.MusicalKey;
using Design.Patterns.Structural.Flyweight.MusicalKey.Enum;
using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight
{
    public static class MusicalKeyFlyweight
    {
        private static readonly IDictionary<MusicalKeys, IMusicalKey> _Notes =
            new Dictionary<MusicalKeys, IMusicalKey>()
            {
                { MusicalKeys.Do, new Do() },
                { MusicalKeys.Re, new Re() },
                { MusicalKeys.Mi, new Mi() },
                { MusicalKeys.Fa, new Fa() },
                { MusicalKeys.Sol, new Sol() },
                { MusicalKeys.La, new La() },
                { MusicalKeys.Si, new Si() },
            };

        public static IMusicalKey Get(MusicalKeys key) =>
            _Notes[key];
    }
}