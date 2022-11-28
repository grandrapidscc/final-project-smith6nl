using CIS129FinalProject.gameclasses;

namespace CIS129FinalProject

{
    /// <summary>
    /// The Adventure class contains the 'world' of the game:
    /// It creates and initializes the player and the map.
    /// </summary>
    /// 
    public class Adventure {
        private RoomList _map;
        private MainCharacter _player;

        public Adventure() {
            /*
            * 
            * Room 0 ----- Room 1
            *    |           |
            * Room 2 ----- Room 3  
            * */

            _map = new RoomList();
            //                                                                                N          S          W          E          */
            
            
            _map.Add(Rm.room0, new Room("room0", "a dank, dark room that smells of troll", Rm.WALL, Rm.room2, Rm.WALL, Rm.room1));
            _map.Add(Rm.room1, new Room("room1", "a light, airy forest shimmering with sunlight", Rm.WALL, Rm.room3, Rm.room0, Rm.WALL));
            _map.Add(Rm.room2, new Room("room2", "a vast cave with walls covered by luminous moss", Rm.room0, Rm.WALL, Rm.WALL, Rm.room3));
            _map.Add(Rm.room3, new Room("room3", "a gloomy dungeon. Rats scurry across its floor", Rm.room1, Rm.WALL, Rm.room2, Rm.WALL));

            _player = new MainCharacter(aRoom);
        }
        
        public MainCharacter Player {        
            get => _player;
        }

        public string MovePlayerTo(Rm newpos) {
            string s;
            if (newpos == Rm.WALL) {
                s = "You bump into a wall.  There is no getting around this..\r\n";
            } else {
                _player.Location = _map.RoomAt(newpos);
                s = $"You are now in the {_player.Location}\r\n";
            }
            return s;
        }
    }
}