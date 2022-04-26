using Design.Patterns.Creational.Builder.Vehicle;
using Design.Patterns.Creational.Builder.Weapon;

namespace Design.Patterns.Creational.Builder.Soldier.Builder
{
    internal class LightInfantrySoldierBuilder : SoldierBuilder
    {
        public LightInfantrySoldierBuilder()
            : base(
                  new LightInfantrySoldier(
                      new Mk48Weapon(),
                      new JeepVehicle()
                      )
                  )
        {
        }
    }
}
