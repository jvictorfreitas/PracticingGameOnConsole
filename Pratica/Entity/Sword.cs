using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Entity
{
    public class Sword
    {
        public Sword(int damage, string name)
        {
            this.Damage = damage;
            this.Name = name;
        }

        public int Damage { get; set; }

        public string Name { get; set; }

    }
}
