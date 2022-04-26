using Design.Patterns.Creational.Builder.Weapon.Interface;

namespace Design.Patterns.Creational.Builder.Weapon
{
    public class Mk48Weapon : IWeapon
    {
        public decimal Damage => BuilderConst.WeaponDamageMk48;
    }
}
