namespace CIS129FinalProject;

/*
     1     2    3    4     5
   ----------------------------
A  | B  |  O | mp | hp | O   | 
   ----------------------------
B  | hp | O  | hp |  G |     | 
   ----------------------------
C  |  mp|  G |  O | mp |     | 
   ----------------------------
D  |    | G  | hp | B  |  G  |
   ----------------------------
E | G   |  B |    | G  |     |
   ----------------------------

B = Banshee Encounter
O = Orc Encounter
G = Goblin Encounter

mp = Magicka Potion
hp = Health Potion

Starting Location and Dungeon Exit will be determined at random

*/

public class Map
{
   public bool dungeonExit = false;
   public static string location = "";
   static string ZONENAME = "";
   static string ZONEDESCRIPTION = "";
   static string ENCOUNTER;
   static string CONSUMABLE;
   static string NORTH = "";
   static string SOUTH = "";
   static string EAST = "";
   static string WEST = "";

   public static Dictionary<string, Dictionary<string, string>> zoneMap = new Dictionary<string, Dictionary<string, string>>()
   {
      {
      "A1",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "A1" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "banshee" },
            { CONSUMABLE, "empty" },
            { NORTH, "wall" },
            { SOUTH, "B1" },
            { EAST, "A2" },
            { WEST, "wall" }
         }
      },
      {
         "A2",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "A2" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "orc" },
            { CONSUMABLE, "empty" },
            { NORTH, "wall" },
            { SOUTH, "B2" },
            { EAST, "A3" },
            { WEST, "A1" }
         }
      },
      {
         "A3",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "A3" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "empty" },
            { CONSUMABLE, "mp" },
            { NORTH, "wall" },
            { SOUTH, "B3" },
            { EAST, "A4" },
            { WEST, "A2" }
         }
      },
      {
         "A4",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "A4" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "empty" },
            { CONSUMABLE, "hp" },
            { NORTH, "wall" },
            { SOUTH, "B4" },
            { EAST, "A5" },
            { WEST, "A3" }
         }
      },
      {
         "A5",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "A5" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "orc" },
            { CONSUMABLE, "hp" },
            { NORTH, "wall" },
            { SOUTH, "B5" },
            { EAST, "wall" },
            { WEST, "A4" }
         }
      },
      {
         "B1",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "B1" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "empty" },
            { CONSUMABLE, "hp" },
            { NORTH, "A1" },
            { SOUTH, "C1" },
            { EAST, "B2" },
            { WEST, "wall" }
         }
      },
      {
         "B2",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "B2" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "orc" },
            { CONSUMABLE, "empty" },
            { NORTH, "" },
            { SOUTH, "" },
            { EAST, "B3" },
            { WEST, "" }
         }
      },
      {
         "B3",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "B3" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "A3" },
            { SOUTH, "C3" },
            { EAST, "B4" },
            { WEST, "B2" }
         }
      },
      {
         "B4",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "B4" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "A4" },
            { SOUTH, "C4" },
            { EAST, "B5" },
            { WEST, "B4" }
         }
      },
      {
         "B5",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "B5" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "A5" },
            { SOUTH, "C5" },
            { EAST, "wall" },
            { WEST, "B4" }
         }
      },
      {
         "C1",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "C1" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "B1" },
            { SOUTH, "D1" },
            { EAST, "C2" },
            { WEST, "wall" }
         }
      },
      {
         "C2",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "C2" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "B2" },
            { SOUTH, "D2" },
            { EAST, "C3" },
            { WEST, "C1" }
         }
      },
      {
         "C3",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "C3" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "B3" },
            { SOUTH, "D3" },
            { EAST, "C4" },
            { WEST, "C2" }
         }
      },
      {
         "C4",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "C4" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "B4" },
            { SOUTH, "D4" },
            { EAST, "C5" },
            { WEST, "C3" }
         }
      },
      {
         "C5",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "C5" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "B5" },
            { SOUTH, "D5" },
            { EAST, "wall" },
            { WEST, "C4" }
         }
      },
      {
         "D1",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "D1" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "C1" },
            { SOUTH, "E1" },
            { EAST, "D2" },
            { WEST, "wall" }
         }
      },
      {
         "D2",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "D2" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "C2" },
            { SOUTH, "E2" },
            { EAST, "D3" },
            { WEST, "D1" }
         }
      },
      {
         "D3",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "D3" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "C3" },
            { SOUTH, "E3" },
            { EAST, "D4" },
            { WEST, "D2" }
         }
      },
      {
         "D4",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "D4" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "C4" },
            { SOUTH, "E4" },
            { EAST, "D5" },
            { WEST, "D3" }
         }
      },
      {
         "D5",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "D5" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "C5" },
            { SOUTH, "E5" },
            { EAST, "wall" },
            { WEST, "D4" }
         }
      },
      {
         "E1",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "E1" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "D1" },
            { SOUTH, "wall" },
            { EAST, "E2" },
            { WEST, "wall" }
         }
      },
      {
         "E2",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "E2" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "D2" },
            { SOUTH, "wall" },
            { EAST, "E3" },
            { WEST, "E1" }
         }
      },
      {
         "E3",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "E3" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "D3" },
            { SOUTH, "wall" },
            { EAST, "E4" },
            { WEST, "E2" }
         }
      },
      {
         "E4",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "E4" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "D4" },
            { SOUTH, "wall" },
            { EAST, "E5" },
            { WEST, "E3" }
         }
      },
      {
         "E5",
         new Dictionary<string, string>
         {
            { ZONENAME, "" },
            { location, "E5" },
            { ZONEDESCRIPTION, "not filled in yet" },
            { ENCOUNTER, "" },
            { CONSUMABLE, "" },
            { NORTH, "D5" },
            { SOUTH, "wall" },
            { EAST, "wall" },
            { WEST, "E4" }
         }
      }
   };

   public void Set(string key ="", string value = "")
   {
      if (zoneMap.ContainsKey(key))
      {
         zoneMap[key] = value;
      }
      else
      {
         Console.WriteLine("Value not in Keys.  Exiting Program");
      }
   }
}