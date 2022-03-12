using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica.Entity;

namespace Pratica.Controller
{
    public class PlayerController : CharacterController
    {
        public bool Escape()
        {
            DicesController dice = new DicesController();

            if(dice.Roll(Enum.DiceType.d6) == 6)
                return true;

            return false;
        }
    }
}
