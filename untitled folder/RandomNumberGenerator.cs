namespace CIS129FinalProject;
using System.Linq;

public class RandomNumberGenerator
{
    // still have to add in random functionality for determining startingLocation as well as dungeonExitPoint
    private static Random RND = new Random();
    private static int _random1 = RND.Next();
    private static int _random2 = RND.Next();
    public static int startingLocation;
    public static int dungeonExitPoint;

    private static int CreateRandomLocations()
    {
        startingLocation = _random1;
        dungeonExitPoint = _random2;

        return startingLocation + dungeonExitPoint;
    }
}
     
    





