namespace CIS129FinalProject
{
    class Program
    {
        public static Player CurrentPlayer = new Player();
        void Main(string[] args)
        {
            while (CurrentPlayer.hp <= 0)
            {
                NoHealth();
            }
        }

        static void StartGame()
        {
             Console.WriteLine("Wizert 5: Retro");
             Console.WriteLine("");
        }

        static void NoHealth()
        {
            Console.WriteLine($"Health points have reached {CurrentPlayer.hp}.  The screen fades and you black out");
            Console.WriteLine();
            
        }
    }
}