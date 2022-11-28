namespace CIS129FinalProject.gameclasses;

public class MainCharacter
{
    private Room _location;
    public MainCharacter( Room aRoom) 
    {
        _location = aRoom;
    }

    public Room Location
    {
        get => _location;
        set => _location = value;
    }
}
