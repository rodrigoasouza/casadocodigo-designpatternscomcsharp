using Design.Patterns.Creational.Builder.Vehicle.Interface;
using Design.Patterns.Creational.Builder.Weapon.Interface;

namespace Design.Patterns.Creational.Builder.Soldier
{
    public class LightInfantrySoldier : BaseSoldier
    {
        public LightInfantrySoldier(IWeapon weapon, IVehicle vehicle) : base(weapon, vehicle)
        {
        }
    }
}
