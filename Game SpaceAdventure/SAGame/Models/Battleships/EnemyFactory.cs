using System;

namespace SAGame.Models.Battleships
{
    public class EnemyFactory : Enemy
    {

        public override void CreateEnemies()
        {
            Enemies.Add(new RamShip(new Position(5, 8)));

            Enemies.Add(new GunShip(new Position(4, 3)));

            Enemies.Add(new WarShip(new Position(3, 8)));
        }

        public void DisplayEnemies()
        {
            foreach (var enemy in Enemies)
            {
                Console.WriteLine();
            }
        }
    }
}
