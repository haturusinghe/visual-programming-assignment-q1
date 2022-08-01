// See https://aka.ms/new-console-template for more information

int runCount = 0;
int playerScore = 0;
int enemyScore = 0;
Console.WriteLine("Student Number: CS/2018/015\n");
while (true)
{
    Console.WriteLine("Press Any Key to Roll Dice\n");
    Console.ReadKey();
    rollDice();
    Console.WriteLine("The score is now - Player: " + playerScore + ". Enemy: "+enemyScore);
    Console.WriteLine();
    runCount++;
    if(runCount == 10)
    {
        if (playerScore > enemyScore)
        {
            Console.WriteLine("You won!");
            
        }
        else if (playerScore < enemyScore)
        {
            Console.WriteLine("You lost!");
        }
        else
        {
            Console.WriteLine("Its a Draw");
        }
        break;
    }
}






void rollDice()
{
    Random r = new Random();
    int numPlayer = r.Next(1, 7);
    int numEnemy = r.Next(1, 7);
    Console.WriteLine("You rolled a random number : " + numPlayer);
    Console.WriteLine("....");
    Console.WriteLine("Enemy AI rolled a random number : " + numEnemy);
    if(numPlayer > numEnemy)
    {
        Console.WriteLine("Player wins this round!");
        playerScore++;
    }
    else if(numPlayer < numEnemy)
    {
        Console.WriteLine("Enemy wins this round!");
        enemyScore++;
    }
    else
    {
        Console.WriteLine("DRAW!");

    }
}