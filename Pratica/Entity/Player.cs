using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Entity
{
    public class Player
    {
        public Player(int lifePoints, string name, Sword sword)
        {
            this.LifePoints = lifePoints;
            this.Name = name; 
            this.Sword = sword;
        }
        
        public int LifePoints { get; set; }

        public string Name { get; set; }

        public Sword Sword { get; set; }

    }
}
