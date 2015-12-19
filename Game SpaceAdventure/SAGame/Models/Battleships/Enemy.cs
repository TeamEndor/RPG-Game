using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame.Models.Battleships
{
    public abstract class Enemy
    {
        private readonly List<Character>enemies = new List<Character>();

        protected Enemy() 
        {
            this.CreateEnemies();
        }

        public List<Character> Enemies
        {
            get { return this.enemies; }
        }

        public abstract void CreateEnemies();
    }
}
