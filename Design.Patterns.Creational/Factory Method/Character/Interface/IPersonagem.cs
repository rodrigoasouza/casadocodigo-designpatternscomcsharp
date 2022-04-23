using Design.Patterns.Creational.Factory_Method.Character.Enums;

namespace Design.Patterns.Creational.Factory_Method.Character.Interface
{
    public interface ICharacter
    {
        Characters Character { get; }

        void HighPunch();
    }
}
