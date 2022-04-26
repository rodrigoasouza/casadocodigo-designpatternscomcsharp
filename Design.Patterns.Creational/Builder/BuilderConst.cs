namespace Design.Patterns.Creational.Builder
{
    public sealed class BuilderConst
    {
        private BuilderConst() { }

        #region Weapon
        public const decimal WeaponDamageMk48 = 31.5M;
        public const decimal WeaponDamageAK47 = 42.7M;
        #endregion

        #region Vehicle
        public const int VehicleSpeedJeep = 57;
        public const int VehicleSpeedHelicopter = 124;
        #endregion
    }
}
