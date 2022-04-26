using Design.Patterns.Creational.Builder.Vehicle.Interface;
using Design.Patterns.Creational.Builder.Weapon.Interface;

namespace Design.Patterns.Creational.Builder.Soldier.Interface
{
    public interface ISoldier
    {
        IWeapon Weapon { get; }
        IVehicle Vehicle { get; }

        void ChooseWeapon(IWeapon weapon);
        void ChooseVehicle(IVehicle vehicle);
    }
}
