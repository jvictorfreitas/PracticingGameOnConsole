using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica.Entity;

namespace Pratica.Controller
{
    public class EnemyController : CharacterController
    {
        public bool DropItem()
        {
            DicesController dicesController = new DicesController();

            if (dicesController.Roll(Enum.DiceType.d6) >= 5) 
                return true; 

            return false;
        }
    }
}
