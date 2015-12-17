using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame.Models.Battleships
{
    public class Starfighter: Player
    {
        private const int DefaultPlayerDamageStatus = 300;
        private const int DefaultPlayerDamage = 75;
        private const int DefaultPlayerEnergy = 100;
        private const int DefaultPlayerMunitions = 200;
        private const int DefaultPlayerQuantityResources = 150;


        public Starfighter(int energy, int munitions, int quantityResources, int damage) : base(energy, munitions, quantityResources, damage)
        {
        }
    }
}
