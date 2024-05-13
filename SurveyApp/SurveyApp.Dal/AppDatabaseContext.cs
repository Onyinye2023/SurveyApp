using Microsoft.EntityFrameworkCore;
using SurveyApp.Domain.Models;

namespace SurveyApp.Dal
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<SurveyLink> SurveyLinks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string
            optionsBuilder.UseSqlServer("Server = DESKTOP-1V17RUA;Database = SurveyApp_db;Trusted_Connection=True;");

        }
    }
}
