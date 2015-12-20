namespace SAGame_v0._2.Models.EnemyBattleShips
{
    public class WarShip : Enemy
    {
       
        private const int DefaultGunShipDamageStatus = 270;
        private const int DefaultGunshipDamage = 100;

        public WarShip(Position position) : base(DefaultGunshipDamage, DefaultGunShipDamageStatus, position)
        {
        }

    }
}
