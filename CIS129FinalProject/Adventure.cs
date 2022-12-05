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

            _player = new MainCharacter(currentRoom);
        }
        
        public MainCharacter Player {        
            get => _player;
        }

        public string MovePlayerTo(RoomList newpos) {
            string s;
            if (_player.Location = _map.RoomAt(newpos)){
                s = $"You are now in the {_player.Location}\r\n";
                Console.WriteLine(_player.Location);
            }
            return s;
        }
    }
}