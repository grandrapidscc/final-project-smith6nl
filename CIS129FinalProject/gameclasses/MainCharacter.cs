namespace CIS129FinalProject.gameclasses;

public class MainCharacter
{
    public static int currentRoom = 1;
    
    private RoomList _map;
    public MainCharacter() 
    {
        
    }

    public RoomList Location
    {
        get => currentRoom;
        set => currentRoom = value;
    }
}
