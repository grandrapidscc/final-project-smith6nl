using System.Data.Common;

namespace CIS129FinalProject.gameclasses;

public class RoomList
{
    private int[,] _map = new int[5, 5]
    {
        {
            0, 1, 2, 3, 4
        },
        {
            5, 6, 7, 8, 9
        },
        {
            10, 11, 12, 13, 14
        },
        {
            15, 16, 17, 18, 19
        },
        {
            20, 21, 22, 23, 24
        }
    };
    /*
    * 
    * Room 00 ----- Room 01 ----- Room 02 ----- Room 03 ----- Room 04
    *    |             |             |             |             |
    * Room 05 ----- Room 06 ----- Room 07 ----- Room 08 ----- Room 09
    *    |             |             |             |             |
    * Room 10 ----- Room 11 ----- Room 12 ----- Room 13 ----- Room 14
    *    |             |             |             |             |
    * Room 15 ----- Room 16 ----- Room 17 ----- Room 18 ----- Room 19
    *    |             |             |             |             |
    * Room 20 ----- Room 21 ----- Room 22 ----- Room 23 ----- Room 24
    * */

    private int newpos;

    public RoomList() { }

    public string RoomAt() {
        newpos = MainCharacter.currentRoom;
    }

    /*public string Describe() {
        string s = "";
        if (this.Count == 0) {
            s = "Nothing in RoomList.";
        } else {
            foreach (KeyValuePair<Rm, Room> kv in this) {
                s = s + kv.Value.Describe() + "\r\n";
            }              
        }
        return s;*/
    }
}
