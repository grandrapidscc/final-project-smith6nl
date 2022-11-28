using System.Data.Common;

namespace CIS129FinalProject;

/*
     
   -------------------------------
  |  1  |  2  |  3  |  4  |  5   | 
  |B mp |  O  |     | hp  | O    | 
   -------------------------------
  |  6  |  7  |  8  |  9  |  10  | 
  | hp  | O   |  hp |   G |      | 
   -------------------------------
  |  11 |  12 |  13 |  14 |  15  |  
  |     |hp  G|  O  | mp  |      | 
   -------------------------------
  | 16  | 17  | 18  | 19  |  20  | 
  |     |  G  | hp  |B  hp|   G  |
   -------------------------------
 |  21 |  22 |  23 |  24 |  25  | 
 | G   |  B  |     | G   |      |
   -------------------------------

B = Banshee Encounter
O = Orc Encounter
G = Goblin Encounter

mp = Magicka Potion
hp = Health Potion

Starting Location and Dungeon Exit will be determined at random

*/
public class Room
{
   private bool _dungeonExit;
   private int _location, _n, _s, _e, _w;
   private string _description, _encounter, _consumable;

   public Room(int location, string description, int n, int s, int e, int w, string encounter, string consumable, bool dungeonExit)
   {
      _location = location;
      _description = description;
      _consumable = consumable;
      _encounter = encounter;
      _dungeonExit = dungeonExit;
      _n = n;
      _s = s;
      _e = e;
      _w = w;
   }
   public int Location
   {
      get => _location;
      set => _location = value;
   }

   public int N
   {
      get => _n;
      set => _n = value;
   }

   public int S
   {
      get => _s;
      set => _s = value;
   }

   public int E
   {
      get => _e;
      set => _e = value;
   }

   public int W
   {
      get => _w;
      set => _w = value;
   }

   public string Encounter
   {
      get => _encounter;
      set => _encounter = value;
   }

   public string Consumable
   {
      get => _consumable;
      set => _consumable = value;
   }
   /*public class Map
{
   
   private void Creating_Rooms()
   {
      Room r1;
      r1 = new Room
      {
         location = 1,
         encounter = "Banshee",
         consumable = "Magicka Potion",
         description = "Very Dark and Smelly",
         name = "Test1",
         dungeonExit = false,
         north = -1,
         south = 6,
         east = 2,
         west = -1
      };

      Room r2;
      r2 = new Room
      {
         location = 2,
         encounter = "Orc",
         consumable = "empty",
         description = "Very Dark and Smelly",
         name = "Test2",
         dungeonExit = false,
         north = -1,
         south = 6,
         east = 3,
         west = 1
      };

      Room r3;
      r3 = new Room
      {
         location = 3,
         encounter = "empty",
         consumable = "empty",
         description = "Nothing moves. You are enveloped in silence.",
         name = "Test3",
         dungeonExit = false,
         north = -1,
         south = 8,
         east = 4,
         west = 2
      };

      Room r4;
      r4 = new Room
      {
         location = 4,
         encounter = "empty",
         consumable = "Health Potion",
         description = "test4",
         name = "Test4",
         dungeonExit = false,
         north = -1,
         south = 9,
         east = 5,
         west = 3
      };

      Room r5;
      r5 = new Room
      {
         location = 5,
         encounter = "Orc",
         consumable = "empty",
         description = "Very Dark and Smelly",
         name = "Test5",
         dungeonExit = false,
         north = -1,
         south = 10,
         east = -1,
         west = 4
      };

      Room r6;
      r6 = new Room
      {
         location = 6,
         encounter = "empty",
         consumable = "Health Potion",
         description = "Test6",
         name = "Test6",
         dungeonExit = false,
         north = 1,
         south = 11,
         east = 7,
         west = -1
      };

      Room r7;
      r7 = new Room
      {
         location = 7,
         encounter = "Orc",
         consumable = "empty",
         description = "Test7",
         name = "Test7",
         dungeonExit = false,
         north = 2,
         south = 12,
         east = 8,
         west = 1
      };

      Room r8;
      r8 = new Room
      {
         location = 8,
         encounter = "Goblin",
         consumable = "Health Potion",
         description = "Very Dark and Smelly",
         name = "Test",
         dungeonExit = false,
         north = 3,
         south = 13,
         east = 9,
         west = 7
      };

      Room r9;
      r9 = new Room
      {
         location = 9,
         encounter = "Goblin",
         consumable = "empty",
         description = "Test9",
         name = "Test9",
         dungeonExit = false,
         north = 4,
         south = 14,
         east = 10,
         west = 8
      };

      Room r10;
      r10 = new Room
      {
         location = 10,
         encounter = "empty",
         consumable = "empty",
         description = "Test10",
         name = "Test10",
         dungeonExit = false,
         north = 5,
         south = 15,
         east = -1,
         west = 9
      };

      Room r11;
      r11 = new Room
      {
         location = 11,
         encounter = "empty",
         consumable = "empty",
         description = "Test11",
         name = "Test11",
         dungeonExit = false,
         north = 6,
         south = 16,
         east = 12,
         west = -1
      };

      Room r12;
      r12 = new Room
      {
         location = 12,
         encounter = "Goblin",
         consumable = "Health Potion",
         description = "Test12",
         name = "Test12",
         dungeonExit = false,
         north = 7,
         south = 17,
         east = 13,
         west = 11
      };

      Room r13;
      r13 = new Room
      {
         location = 13,
         encounter = "Orc",
         consumable = "empty",
         description = "Test13",
         name = "Test13",
         dungeonExit = false,
         north = 8,
         south = 18,
         east = 14,
         west = 12
      };

      Room r14;
      r14 = new Room
      {
         location = 14,
         encounter = "empty",
         consumable = "Magicka Potion",
         description = "Test14",
         name = "Test14",
         dungeonExit = false,
         north = 9,
         south = 19,
         east = 15,
         west = 13
      };

      Room r15;
      r15 = new Room
      {
         location = 15,
         encounter = "empty",
         consumable = "empty",
         description = "Test15",
         name = "Test15",
         dungeonExit = false,
         north = 10,
         south = 20,
         east = -1,
         west = 19
      };

      Room r16;
      r16 = new Room
      {
         location = 16,
         encounter = "empty",
         consumable = "empty",
         description = "Test16",
         name = "Test16",
         dungeonExit = false,
         north = 11,
         south = 21,
         east = 17,
         west = -1
      };

      Room r17;
      r17 = new Room
      {
         location = 17,
         encounter = "Goblin",
         consumable = "empty",
         description = "Test17",
         name = "Test17",
         dungeonExit = false,
         north = 12,
         south = 22,
         east = 18,
         west = 16
      };

      Room r18;
      r18 = new Room
      {
         location = 18,
         encounter = "empty",
         consumable = "Health Potion",
         description = "Test18",
         name = "Test18",
         dungeonExit = false,
         north = 13,
         south = 23,
         east = 19,
         west = 17
      };

      Room r19;
      r19 = new Room
      {
         location = 19,
         encounter = "Banshee",
         consumable = "Health Potion",
         description = "Test19",
         name = "Test19",
         dungeonExit = false,
         north = 14,
         south = 24,
         east = 20,
         west = 18
      };

      Room r20;
      r20 = new Room
      {
         location = 20,
         encounter = "Goblin",
         consumable = "empty",
         description = "Test20",
         name = "Test20",
         dungeonExit = false,
         north = 15,
         south = 25,
         east = -1,
         west = 19
      };

      Room r21;
      r21 = new Room
      {
         location = 21,
         encounter = "Goblin",
         consumable = "empty",
         description = "Test21",
         name = "Test21",
         dungeonExit = false,
         north = 16,
         south = -1,
         east = 22,
         west = -1
      };

      Room r22;
      r22 = new Room
      {
         location = 22,
         encounter = "Banshee",
         consumable = "empty",
         description = "Test22",
         name = "Test22",
         dungeonExit = false,
         north = 17,
         south = -1,
         east = 23,
         west = 21
      };

      Room r23;
      r23 = new Room
      {
         location = 23,
         encounter = "empty",
         consumable = "empty",
         description = "Test23",
         name = "Test23",
         dungeonExit = false,
         north = 18,
         south = -1,
         east = 24,
         west = 22
      };

      Room r24;
      r24 = new Room
      {
         location = 24,
         encounter = "Goblin",
         consumable = "empty",
         description = "Test24",
         name = "Test24",
         dungeonExit = false,
         north = 19,
         south = -1,
         east = 25,
         west = 23
      };

      Room r25;
      r25 = new Room
      {
         location = 25,
         encounter = "empty",
         consumable = "empty",
         description = "Test25",
         name = "Test25",
         dungeonExit = false,
         north = 20,
         south = -1,
         east = -1,
         west = 24};
   
   private Rooms[] fullMap;
   fullMap = new Rooms[24];
   Room[0] map = r1;
   Room[1] = r2;
   map[2] = r3;
   map[3] = r4;
   map[4] = r4;
   map[5] = r5;
   map[6] = r6;
   map[7] = r7;
   map[8] = r8;
   map[9] = r9;
   map[10] = r10;
   map[11] = r11;
   map[12] = r12;
   map[13] = r13;
   map[14] = r14;
   map[15] = r15;
   map[16] = r16;
   map[17] = r17;
   map[18] = r18;
   map[19] = r19;
   map[20] = r20;
   map[21] = r21;
   map[22] = r22;
   map[23] = r23;
   map[24] = r24;
   }

   public String GetDescription()
   {
      return "This is " + _description;
   }

   public void setDescription(String aDescription)
   {
      _description = aDescription;
   }
   /*private void InitGame()
   {
      _player = new Player();
   }*/
   
}

   