using static System.Environment;

namespace CIS129FinalProject;

public class ActionMenu
{
    public static void AreaEntry()
    {
 
    }
    public static void NavMenu()
    {
        string userChoice = "";

        while (userChoice.ToLower() != "w" ||
               userChoice.ToLower() != "a" ||
               userChoice.ToLower() != "s" ||
               userChoice.ToLower() != "d")
        {
            Console.WriteLine("Choose an action!");
            Console.WriteLine("Press 'w' to go North");
            Console.WriteLine("Press 's' to go South");
            Console.WriteLine("Press 'a' to go West");
            Console.WriteLine("Press 'd' to go East");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "w":
                    Player_Move(userChoice);
                    break;
                case "s":

                    break;
                case "a":

                    break;
                case "d":

                    break;
                case "quit":
                    QuitGame.ExitGame();
                    break;
            }
        }
    }

    public static void Player_Move(string userChoice)
    {

        switch (userChoice)
        {
            case "w":
                var qry = from outer in Map.zoneMap
                    from inner in outer.Value
                    select outer.Key + "->>" + inner.Key + ", " + inner.Value;



                break;
            case "s":

                break;
            case "a":

                break;
            case "d":

                break;

        }

    }
}