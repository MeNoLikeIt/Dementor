using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dementor.DAL.dtos;

namespace Dementor.DAL.Database
{
    public class DementorDatabase:DbContext
    {
        public DbSet<Glober> Globers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Report> Reports { get; set; }

        public DbSet<Mentoring> Mentorings { get; set; }

        public DementorDatabase():base("name=Dementor")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Glober>().ToTable("Globers");
            modelBuilder.Entity<Feedback>().ToTable("Feedbacks");
            modelBuilder.Entity<Mood>().ToTable("Moods");
            modelBuilder.Entity<Report>().ToTable("Reports");
            modelBuilder.Entity<Mentoring>().ToTable("Mentorings");
        }
    }
}
