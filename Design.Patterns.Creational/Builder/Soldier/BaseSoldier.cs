using Design.Patterns.Creational.Builder.Soldier.Interface;
using Design.Patterns.Creational.Builder.Vehicle.Interface;
using Design.Patterns.Creational.Builder.Weapon.Interface;

namespace Design.Patterns.Creational.Builder.Soldier
{
    public abstract class BaseSoldier : ISoldier
    {
        protected BaseSoldier(IWeapon weapon, IVehicle vehicle)
        {
            Weapon = weapon;
            Vehicle = vehicle;
        }

        public IWeapon Weapon { get; private set; }

        public IVehicle Vehicle { get; private set; }

        public virtual void ChooseVehicle(IVehicle vehicle) =>
            Vehicle = vehicle;

        public virtual void ChooseWeapon(IWeapon weapon) =>
            Weapon = weapon;
    }
}
