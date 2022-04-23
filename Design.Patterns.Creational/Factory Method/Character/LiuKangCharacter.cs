using Design.Patterns.Creational.Factory_Method.Character.Enums;
using Design.Patterns.Creational.Factory_Method.Character.Interface;

namespace Design.Patterns.Creational.Factory_Method.Character
{
    public class LiuKangCharacter : ICharacter
    {
        public Characters Character => Characters.LiuKang;

        public void HighPunch()
        {
            Console.WriteLine(Character);
        }
    }
}
