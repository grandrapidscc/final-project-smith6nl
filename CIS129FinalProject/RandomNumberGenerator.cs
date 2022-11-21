namespace CIS129FinalProject;
using System.Linq;

public class RandomNumberGenerator
{
    // still have to add in random functionality for determining startingLocation as well as dungeonExitPoint
    private static Random RND = new Random();
    private static int random1 = RND.Next();
    private static int random2 = RND.Next();
    public static string startingLocation = "1A";
    public static string dungeonExitPoint = "4A";

    public static List<string> mapLocations = new List<string>();



    public string MapLocationList(int rnd)
    {
        mapLocations.Add("A1");
        mapLocations.Add("A2");
        mapLocations.Add("A3");
        mapLocations.Add("A4");
        mapLocations.Add("A5");
        mapLocations.Add("B1");
        mapLocations.Add("B2");
        mapLocations.Add("B3");
        mapLocations.Add("B4");
        mapLocations.Add("B5");
        mapLocations.Add("C1");
        mapLocations.Add("C2");
        mapLocations.Add("C3");
        mapLocations.Add("C4");
        mapLocations.Add("C5");
        mapLocations.Add("D1");
        mapLocations.Add("D2");
        mapLocations.Add("D3");
        mapLocations.Add("D4");
        mapLocations.Add("D5");
        mapLocations.Add("E1");
        mapLocations.Add("E2");
        mapLocations.Add("E3");
        mapLocations.Add("E4");
        mapLocations.Add("E5");

        return startingLocation + dungeonExitPoint;
    }
}




