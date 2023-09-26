using System;
using System.Linq;


namespace LINQ_ZM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //makes a list of 10 games, varing from names, esrbs, and genre.
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("CS:GO", 'M', "FPS"),
                new Game("Elden Ring", 'M', "Action-Adventure"),
                new Game("Valorant", 'T', "FPS"),
                new Game("Halo 3", 'M', "Action"),
                new Game("Zombcube", 'E', "FPS Survival"),
                new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
                new Game("Paddle Balls", 'E', "Arcade Casual"),
                new Game("Rocket League", 'E', "Action Racing"),
                new Game("Fifa 22", 'E', "Sport"),
            };

            //puts the games with a title from 8 or less into the "shortGames" list.
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            //foreach game in shortGames, it will show up in the WriteLine.
            foreach(var game in shortGames) 
            { 
                Console.WriteLine(game);
            }

            //turns mineCraft into a variable, showing the title, ESRB, and Genre.
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                             .Select(Game => $"Title: {Game.Title}, ESRB: {Game.Esrb}, Genre: {Game.Genre}");

            Console.WriteLine(mineCraft.FirstOrDefault());

            //makes a variable called tRated, placing T rated games in the list.
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            //WriteLines the T Rated Games and makes it into a list.
            Console.WriteLine("T Rated Games:");
            foreach(var game in tRated) 
            {
                Console.WriteLine(game);
            }

            //makes eRatedAction into a variable, looking for E Rated games that have the genre Action.
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            //displays E Rated Action Games and put them in a list.
            Console.WriteLine("E Rated Action Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}