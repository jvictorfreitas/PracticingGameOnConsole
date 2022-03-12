using Pratica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Controller
{
    public class CharacterController
    {
        public bool IsDead(Character character)
        {
            if (character.LifePoints <= 0)
                return true;

            return false;
        }
    }
}
