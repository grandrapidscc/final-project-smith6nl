namespace CIS129FinalProject;

public class Voices
{
    public static void Narrator()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static void Player()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void Unknown()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }

    public static void Settings()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}