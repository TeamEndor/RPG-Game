namespace SAGame_v0._2.Models.EnemyBattleShips
{
    public class GunShip : Enemy
    {
        
        private const int DefaultGunShipDamageStatus = 150;
        private const int DefaultGunshipDamage = 60;


        public GunShip(Position position) : base(DefaultGunshipDamage, DefaultGunShipDamageStatus, position)
        {
        }

    }
}
