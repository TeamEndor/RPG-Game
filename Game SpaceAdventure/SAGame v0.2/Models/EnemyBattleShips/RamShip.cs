namespace SAGame_v0._2.Models.EnemyBattleShips
{
    public class RamShip : Enemy
    {
        
        private const int DefaultGunShipDamageStatus = 200;
        private const int DefaultGunshipDamage = 150;

        public RamShip(Position position) : base(DefaultGunshipDamage, DefaultGunShipDamageStatus, position)
        {

        }

    }
}
