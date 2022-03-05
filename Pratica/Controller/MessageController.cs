using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Controller
{
    public class MessageController
    {
        public void ClickToContinue()
        {
            Console.WriteLine("Aperte Qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        public void ClickToContinueEnemyDefeated()
        {
            Console.WriteLine("Inimigo derrotado, Aperte Qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        public void GameOver()
        {
            Console.Clear();
            Console.WriteLine("GAME OVER!");
            Console.ReadLine();
        }

        public void ClickToRollTheDice()
        {
            Console.WriteLine("Aperte Qualquer tecla para rolar o dado");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
