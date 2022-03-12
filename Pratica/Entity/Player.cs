using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Entity
{
    public class Player : Character
    {
        public Player(int lifePoints, string name, Sword sword)
        {
            this.LifePoints = lifePoints;
            this.Name = name; 
            this.Sword = sword;
        }
        
    }
}
