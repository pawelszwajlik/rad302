using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class Game
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
    }

    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public GameContext() : base("GamesConnection")
        {

        }
    }
}