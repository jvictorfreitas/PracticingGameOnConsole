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
        public int Roll(int quantityDices, Enum.DiceType Dice)
        {
            MessageController messageController = new MessageController();
            Random random = new Random();

            messageController.ClickToRollTheDice();
            int roll = 0;
            for (int i = 0; i < quantityDices; i++)
            {
                roll += random.Next(quantityDices, ((int)Dice)+1);
            }
            
            Console.WriteLine("Resultado: {0}", roll);
            
            return roll;
        }
    }
}
