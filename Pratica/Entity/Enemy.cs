using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Entity
{
    public class Enemy : Character
    {
        public Enemy(Sword sword)
        {
            Random random = new Random();

            this.LifePoints = random.Next(2,6);
            this.Name = "Enemy";
            this.Sword = sword;

        }

    }
}
