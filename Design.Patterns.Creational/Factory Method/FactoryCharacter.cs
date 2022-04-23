using Design.Patterns.Creational.Factory_Method.Character;
using Design.Patterns.Creational.Factory_Method.Character.Enums;
using Design.Patterns.Creational.Factory_Method.Character.Interface;

namespace Design.Patterns.Creational.Factory_Method
{
    public class FactoryCharacter
    {
        public const int FirstPosition = 1;

        public ICharacter Factory(Characters character)
        {
            ICharacter result;

            switch (character)
            {
                case Characters.LiuKang:
                    result = new LiuKangCharacter();
                    break;
                case Characters.SubZero:
                    result = new SubZeroCharacter();
                    break;
                case Characters.ShangTsung:
                    result = new ShangTsungCharacter();
                    break;
                default:
                    var randomCharacter = RandomCharacter();
                    result = Factory(randomCharacter);
                    break;
            }

            return result;
        }

        public Characters RandomCharacter()
        {
            var values = Enum.GetValues(typeof(Characters));
            var valuesCast = values.Cast<Characters>();
            var last = valuesCast.Last();
            var max = (int)last;
            var maxRandom = max + 1;

            var random = new Random();
            var character = random.Next(FirstPosition, maxRandom);

            return (Characters)character;
        }
    }
}
