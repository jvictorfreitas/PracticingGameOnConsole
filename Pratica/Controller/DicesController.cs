using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica.Entity;

namespace Pratica.Controller
{
    public class DicesController
    {
        public int Roll()
        {
            MessageController messageController = new MessageController();
            Random random = new Random();

            messageController.ClickToRollTheDice();
            int roll = random.Next(1, 7);
            
            Console.WriteLine("Resultado: {0}", roll);
            
            return roll;
        }
    }
}
