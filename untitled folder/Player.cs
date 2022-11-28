using System.Runtime.Intrinsics.Arm;

namespace CIS129FinalProject;


public class Player : Thing
{
    Private Room _location;
}
{
    public Adventure()
    {
        _player = new PlayerProfile(100, 100,, _startingLocation);
    }

    public Actor Player
    {
        get => _player;
    }
    private void MovePlayer(Dir direction)
    {
        outputTB.Text = AdvSimd.MovePlayerTo(direction);
        if (newpos == -1)
        {
            Console.WriteLine("You run into a wall.  There is no way around or over it.");
        }
        else
        {
            _player.Location = map[newpos];
            Console.WriteLine($"You enter  an area that is {_player.Location.Description}");
        }
        
    }
    private int _hp = 100;
    private int _mp = 200;
    private int _location = 0;
    /*private string _action1 = "Fireball";
    private string _action2 = "Heal";
    private string _action3 = "Flee";
    private int _actiondmg1 = 5;
    private int _actiondmg2 = 3;
    private int _actioncost1 = 3;
    private int _actioncost2 = 5;  */  
        
    private void PlayerProfile (int hp, int mp, int playerLocation)
    {
        _hp = hp;
        _mp = mp;
        _location = playerLocation;
    }

    public int PlayerLocation
    {
        get => _location;
        set => _location = value;
    }
    public Actor Player
}