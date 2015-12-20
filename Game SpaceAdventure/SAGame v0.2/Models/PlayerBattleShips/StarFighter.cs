namespace SAGame_v0._2.Models.PlayerBattleShips
{
    public class StarFighter : Player
    {
        private const int DefaultPlayerXPosition = 0;
        private const int DefaultPlayerYPosition = 0;

        private const int DefaultStartfighterMunitions = 100;
        private const int DefaultStartfighterEnergy = 100;
        private const int DefaultStartfighterDamage = 75;
        private const int DefaultStartfighterDamageStatus = 140;


        public StarFighter() :
            base(DefaultStartfighterMunitions, DefaultStartfighterEnergy, DefaultStartfighterDamage, 
                DefaultStartfighterDamageStatus, new Position(DefaultPlayerXPosition, DefaultPlayerYPosition))
        {
        }
    }
}
