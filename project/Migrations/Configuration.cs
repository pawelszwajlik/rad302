namespace project.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<project.Models.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(project.Models.GameContext context)
        {
            List<Game> games = new List<Game>()
            {
                new Game() { Name = "Assassin's Creed (video game)"},
                new Game() { Name = "Assassin's Creed 2"},
                new Game() { Name = "Assassin's Creed: Brotherhood"},
                new Game() { Name = "Assassin's Creed: Revelations"},
                new Game() { Name = "Assassin's Creed 3"},
                new Game() { Name = "Baldur's Gate"},
                new Game() { Name = "Baldur's Gate 2" },
                new Game() { Name = "Crysis" },
                new Game() { Name = "Crysis Warhead" },
                new Game() { Name = "Crysis 2"},
                new Game() { Name = "Crysis 3"},
                new Game() { Name = "Dead Space (series)"},
                new Game() { Name = "Fallout (video game)"},
                new Game() { Name = "Fallout 2"},
                new Game() { Name = "Far Cry (video game)"},
                new Game() { Name = "Far Cry 2"},
                new Game() { Name = "Hype: The Time Quest"},
                new Game() { Name = "Mass Effect (Video Game)" },
                new Game() { Name = "Mass Effect 2"},
                new Game() { Name = "Mass Effect 3"},
                new Game() { Name = "Max Payne (Video Game)"},
                new Game() { Name = "Splinter Cell : Chaos Theory"},
                new Game() { Name = "Star Wars: Knights of the Old Republic"},
                new Game() { Name = "The Elder Scrolls I: Arena"},
                new Game() { Name = "The Elder Scrolls II: Daggerfall"},
                new Game() { Name = "The Elder Scrolls III: Morrowind"},
                new Game() { Name = "The Elder Scrolls IV: Oblivion"},
                new Game() { Name = "The Elder Scrolls V: Skyrim"}
            };
            
            games.ForEach(g => context.Games.Add(g));
            context.SaveChanges();
        }
    }
}
