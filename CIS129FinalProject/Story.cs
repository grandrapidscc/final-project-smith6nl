namespace CIS129FinalProject;

public class Story
{
    public static void StartGame()
    {
        Console.WriteLine("--------------------------------------------------------------\n" +
                          "------*****-*---*-*****---*****---***----*-----*--*****-------\n" +
                          "--------*---*---*-*------*-------*---*---*-----*--*-----------\n" +
                          "--------*---*****-***---*-------*******--*-----*--***---------\n" +
                          "--------*---*---*-*------*------*-----*---*---*---*-----------\n" +
                          "--------*---*---*-*****---*****-*-----*----***----*****-------\n" +
                          "--------------------------------------------------------------\n");
        
        Voices.Narrator();
        Console.WriteLine("What is your Hero's Name?");
        Console.WriteLine();
        Console.WriteLine("You jolt from a dead sleep after hearing a booming voice speak to\n" +
                          "you\n" +
                          "My name is Wizert!" +
                          "...Wait what? That's not my name?  My name is Greg. Who are you?  \n" +
                          "Why is this thing talking for me?!");                    
        Console.WriteLine("Oh Hush.  We are following this quest. You are Wizert!");
        Console.WriteLine("Wizert 5: Retro");
        Console.WriteLine("");
    }
}