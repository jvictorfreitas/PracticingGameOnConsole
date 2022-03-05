using Pratica.Entity;
using Pratica.Controller;
using Pratica.Enum;

try
{
    bool isRuning = true;
    Sword sword = new Sword(2,DiceType.d6,1,"Sword Soul");
    Player player = new Player(10,"JottaVe", sword);
    
    DicesController dicesController = new DicesController();
    PlayerController playerController = new PlayerController();
    EnemyController enemyController = new EnemyController();
    MessageController messageController = new MessageController(); 
    
    while (isRuning) 
    {
        Enemy enemy = new Enemy(sword);
        while (!enemyController.IsDead(enemy))
        {
            if (dicesController.Roll(player.Sword.QuantityDices, player.Sword.Dice) <= 2)
                playerController.TakeDamage(player,enemy);
            else
                enemyController.TakeDamage(enemy,player);

            if (playerController.IsDead(player))
                break;
            messageController.ClickToContinue();

        }

        if (playerController.IsDead(player))
            isRuning = false;
        else
        {
            messageController.ClickToContinueEnemyDefeated();
        }
    }

    messageController.GameOver();
}
catch(Exception ex) 
{
    Console.WriteLine(ex.Message);
}
