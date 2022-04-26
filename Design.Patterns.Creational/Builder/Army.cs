using Design.Patterns.Creational.Builder.Soldier.Builder;
using Design.Patterns.Creational.Builder.Soldier.Interface;

namespace Design.Patterns.Creational.Builder
{
    public class Army
    {
        public IList<ISoldier> Soldiers { get; set; } = new List<ISoldier>();

        public void AddSoldier(SoldierBuilder builder)
        {
            var soldier = builder.Soldier;
            Soldiers.Add(soldier);
        }
    }
}
