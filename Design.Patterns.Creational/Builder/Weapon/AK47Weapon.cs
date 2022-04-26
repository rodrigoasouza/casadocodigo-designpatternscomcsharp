using Design.Patterns.Creational.Builder.Weapon.Interface;

namespace Design.Patterns.Creational.Builder.Weapon
{
    internal class AK47Weapon : IWeapon
    {
        public decimal Damage => BuilderConst.WeaponDamageAK47;
    }
}
