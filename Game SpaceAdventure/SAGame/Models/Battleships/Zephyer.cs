using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame.Models.Battleships
{
    public class Zephyer:Player
    {
        private const int DefaultZephyerXPosition = 0;
        private const int DefaultZephyerYPosition = 0;

        private const int DefaultZephyerMunitions = 150;
        private const int DefaultZephyerEnergy = 100;
        private const int DefaultZephyerDamage = 85;
        private const int DefaultZephyerDamageStatus = 110;

        public Zephyer() : base(DefaultZephyerMunitions, DefaultZephyerEnergy, DefaultZephyerDamage, DefaultZephyerDamageStatus, new Position(DefaultZephyerXPosition,DefaultZephyerYPosition))
        {
        }
    }
}
