using Design.Patterns.Creational.Builder.Soldier.Interface;

namespace Design.Patterns.Creational.Builder.Soldier.Builder
{
    public abstract class SoldierBuilder
    {
        protected SoldierBuilder(ISoldier soldier)
        {
            Soldier = soldier;
        }

        public ISoldier Soldier { get; protected set; }
    }
}
