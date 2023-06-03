using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using FigureSkatingAPI.Models;

namespace FigureSkatingAPI.Models
{
	public class FigureSkatingAPIDBContext : DbContext
	{
		protected readonly IConfiguration Configuration;

		public FigureSkatingAPIDBContext(DbContextOptions<FigureSkatingAPIDBContext> options, IConfiguration configuration) : base(options)
		{
			Configuration = configuration;
		}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
			var connectionString = Configuration.GetConnectionString("FigureSkating");
			options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Skater>().Property(e => e.SkaterId).ValueGeneratedNever();
            modelBuilder.Entity<Skater>().HasKey(e => e.SkaterId);
            modelBuilder.Entity<Competition>().Property(e => e.CompetitionId).ValueGeneratedNever();
            modelBuilder.Entity<Competition>().HasKey(e => e.CompetitionId);
        }

        public DbSet<Skater> Skaters { get; set; } = null!;
		public DbSet<Competition> Competitions { get; set; } = null!;
    }
}

