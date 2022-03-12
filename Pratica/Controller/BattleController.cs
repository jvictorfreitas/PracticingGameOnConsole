using Pratica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Controller
{
    public class BattleController
    {
        public void Damage(Character characterDealDamage, Character characterTakeDamage)
        {
            Console.WriteLine("{0} recebeu {1} de dano", characterDealDamage.Name, characterTakeDamage.Sword.Damage);
            characterDealDamage.LifePoints -= characterTakeDamage.Sword.Damage;

            Console.WriteLine("Vida Atual: {0}", characterDealDamage.LifePoints);
        }

    }
}
