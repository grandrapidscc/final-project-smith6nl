namespace CIS129FinalProject;
using CIS129FinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        /*begin the story - introduction - while loop that
         keeps an eye on hp and will trigger end game screen 
         if they drop to 0 */
            Room room0;
            Room room1;
            Room room2;
            Room room3;

            Room[] map;
            //int location, string description, int n, int s, int e, int w, string encounter, string consumable, bool dungeonExit
            //location              description             N    S     E     W      encounter       consumable      dungeonExit
            room0 = new Room(1, "Dank and Dark", -1, 2, 1, -1, "empty", "empty", false);
            room1 = new Room(2, "Dank and Dark", -1, 3, -1, 0, "empty", "empty", false);
            room2 = new Room(3, "Dank and Dark", 0, -1, 3, -1, "empty", "empty", false);
            room3 = new Room(4, "Dank and Dark", 1, -1, -1, 2, "empty", "empty", true);

            map = new Room [4];
            map[0] = room0;
            map[1] = room1;
            map[2] = room2;
            map[3] = room3;
    
            Story.StartGame();
            

               
            
            Console.WriteLine($"{room0.Location} is {roo}. You have encountered a {r1.encounter} and if you win the fight, a {r1.consumable} will be awarded.  The exits as it stands are {r.r1.north}(North), {r1.south}(South), {r1.east}(East), and {r1.west}(West) ");
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

            void InitGame()
            {
                throw new NotImplementedException();
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