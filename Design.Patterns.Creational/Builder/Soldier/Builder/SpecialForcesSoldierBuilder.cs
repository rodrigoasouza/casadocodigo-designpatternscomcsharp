using Design.Patterns.Creational.Builder.Vehicle;
using Design.Patterns.Creational.Builder.Weapon;

namespace Design.Patterns.Creational.Builder.Soldier.Builder
{
    internal class SpecialForcesSoldierBuilder : SoldierBuilder
    {
        public SpecialForcesSoldierBuilder() :
            base(
                new SpecialForcesSoldier(
                    new AK47Weapon(),
                    new HelicopterVehicle()
                    )
                )
        {
        }
    }
}
