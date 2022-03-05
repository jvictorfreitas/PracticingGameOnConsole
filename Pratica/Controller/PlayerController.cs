using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica.Entity;

namespace Pratica.Controller
{
    internal class PlayerController
    {
        public void TakeDamage(Player player, Enemy enemy)
        {
            Console.WriteLine("{0} recebeu {1} de dano", player.Name, enemy.Sword.Damage);
            player.LifePoints -= enemy.Sword.Damage;

            Console.WriteLine("Vida Atual: {0}", player.LifePoints);
        }

        public bool IsDead(Player player)
        {
            if (player.LifePoints <= 0)
                return true;

            return false;
        }

        public void Escape()
        {
            MessageController messageController = new MessageController();
            
        }
    }
}
