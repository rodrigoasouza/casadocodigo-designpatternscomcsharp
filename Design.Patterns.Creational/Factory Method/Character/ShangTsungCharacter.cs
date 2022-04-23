using Design.Patterns.Creational.Factory_Method.Character.Enums;
using Design.Patterns.Creational.Factory_Method.Character.Interface;

namespace Design.Patterns.Creational.Factory_Method.Character
{
    public class ShangTsungCharacter : ICharacter
    {
        public ShangTsungCharacter()
        {
            TransformedInto = Characters.ShangTsung;
        }

        private Characters TransformedInto;

        public Characters Character => Characters.ShangTsung;

        public void HighPunch()
        {
            Console.WriteLine(TransformedInto);
        }
    }
}
