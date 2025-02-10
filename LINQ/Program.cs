namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Dota", "AmongUs", "EldenRing" };
            videoGames.Add("League");
            videoGames.Add("Fortnite");
            
            var orderedGames= videoGames.OrderBy(name => name.Length);

            foreach (var games in orderedGames)
            {
                Console.WriteLine(games);
            }
            {
                
            }
        }
    }
}
