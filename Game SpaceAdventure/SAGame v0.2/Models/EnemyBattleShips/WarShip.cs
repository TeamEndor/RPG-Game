namespace SAGame_v0._2.Models.EnemyBattleShips
{
    public class WarShip : Enemy
    {
        private const string DefaultWarShipName = "Warship";
        private const int DefaultWarShipDamage = 100;
        private const int DefaultWarShipShieldStatus = 270;

        public WarShip(Position position) 
            : base(DefaultWarShipName, DefaultWarShipDamage, DefaultWarShipShieldStatus, position)
        {
        }

    }
}
