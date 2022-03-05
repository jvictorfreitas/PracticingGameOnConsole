using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica.Entity;

namespace Pratica.Controller
{
    public class EnemyController
    {
        public void TakeDamage(Enemy enemy, Player player)
        {
            Console.WriteLine("{0} recebeu {1} de dano", enemy.Name, player.Sword.Damage);
            enemy.LifePoints -= player.Sword.Damage;

            Console.WriteLine("Vida Atual: {0}", enemy.LifePoints);
        }

        public bool IsDead(Enemy enemy)
        {
            if (enemy.LifePoints <= 0)
                return true;

            return false;
        }
    }
}
