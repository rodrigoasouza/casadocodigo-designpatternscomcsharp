using Design.Patterns.Creational.Factory_Method.Character.Interface;

namespace Design.Patterns.Creational.Factory_Method.Character
{
    public class SubZeroCharacter : ICharacter
    {
        public Enums.Characters Character => Enums.Characters.SubZero;

        public void HighPunch()
        {
            Console.WriteLine(Character);
        }
    }
}
