using Pratica.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Entity
{
    public class Sword
    {
        public Sword(int damage, DiceType dicesAttack,int quantityDices, string name)
        {
            this.Damage = damage;
            this.Name = name;
            this.Dice = dicesAttack;
            this.QuantityDices = quantityDices;
        }

        public int Damage { get; set; }
        public DiceType Dice { get; set; }
        public int QuantityDices { get; set; }
        public string Name { get; set; }

    }
}
