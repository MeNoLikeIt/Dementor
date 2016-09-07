using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Dementor.DAL.dtos;

namespace Dementor.DAL.Database
{
    public class Configuration : DbMigrationsConfiguration<DementorDatabase>
    {
        public Configuration ()
        {
            AutomaticMigrationsEnabled = false;
            CommandTimeout = 60 * 5;
        }

        protected override void Seed (DementorDatabase context)
        {
            context.Moods.AddOrUpdate(m => m.Id, new Mood { Id = 1, Description = "Happy" }, new Mood { Id = 2, Description = "Issues" }, new Mood { Id = 3, Description = "Problem" });
        }
    }
}
