namespace SAGame_v0._2.Models.EnemyBattleShips
{
    public class RamShip : Enemy
    {
        private const string DefaultRamShipName = "Ramship";
        private const int DefaultRamShipDamage = 150;
        private const int DefaultRamShipShieldStatus = 200;

        public RamShip(Position position) 
            : base(DefaultRamShipName, DefaultRamShipDamage, DefaultRamShipShieldStatus, position)
        {

        }

    }
}
