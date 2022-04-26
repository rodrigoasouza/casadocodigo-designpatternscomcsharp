using Design.Patterns.Creational.Builder.Soldier.Builder;

namespace Design.Patterns.Creational.Builder
{
    public class ExampleBuilder
    {
        public Army GetArmy()
        {
            var result = new Army();

            result.AddSoldier(new LightInfantrySoldierBuilder());
            result.AddSoldier(new LightInfantrySoldierBuilder());
            result.AddSoldier(new LightInfantrySoldierBuilder());

            result.AddSoldier(new SpecialForcesSoldierBuilder());

            return result;
        }
    }
}
