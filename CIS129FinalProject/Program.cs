namespace CIS129FinalProject
{
    class Program
    {

        public static Player currentPlayer = new Player();

        private static void Main(string[] args)
        {
            /*begin the story - introduction - while loop that
             keeps an eye on hp and will trigger end game screen 
             if they drop to 0 */

            currentPlayer.name = "Wizert";
            Story.StartGame();
        }
    }
}
/*while (currentPlayer.hp >= 0)
{
    while (currentPlayer.location != RandomNumberGenerator.dungeonExitPoint)
    {
        Story.StartGame();
    }
        
}
//when while loop ends - sends out to end game screen
NoHealth();
}



static void NoHealth()
{
    Console.WriteLine(
        $"Health points have reached {currentPlayer.hp}.  The screen fades and you black out");
    Console.WriteLine();

}

static void InvalidOperationException()
{
    Console.WriteLine("Name cannot be blank.  Please Try again.");
    currentPlayer.name = Console.ReadLine();
}
}
}*/