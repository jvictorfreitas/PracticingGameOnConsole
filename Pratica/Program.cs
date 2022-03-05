using Pratica.Entity;
using Pratica.Controller;

try
{
    bool isRuning = true;
    Sword sword = new Sword(2,"Sword Soul");
    Player player = new Player(10,"JottaVe", sword);
    
    DicesController dicesController = new DicesController();
    PlayerController playerController = new PlayerController();
    EnemyController enemyController = new EnemyController();
    MessageController messageController = new MessageController(); 
    
    while (isRuning) 
    {
        Enemy enemy = new Enemy(sword);
        while (enemyController.IsDead(enemy))
        {
            if ( dicesController.Roll() <= 2)
                playerController.TakeDamage(player,enemy);
            else
                enemyController.TakeDamage(enemy,player);

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
