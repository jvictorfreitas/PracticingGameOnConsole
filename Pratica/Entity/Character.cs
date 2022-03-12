using Pratica.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Entity
{
    public class Character
    {
        public string Name { get; set; }
        public int LifePoints { get; set; }
        public Sword Sword { get; set; }
    }
}
