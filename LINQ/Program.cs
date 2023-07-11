namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Sonic", "Double Dragon", "Double Dribble", "Techmo Bowl" };
            videoGames.Add("Mario Bros");
            videoGames.Add("Super Smash Bros. Melee");

            var orderedvideoGames = videoGames.OrderBy(name => name.Length);

            foreach (var game in orderedvideoGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
