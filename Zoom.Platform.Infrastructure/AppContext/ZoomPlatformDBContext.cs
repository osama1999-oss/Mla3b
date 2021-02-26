using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zoom.Platform.Core.Model;
using Zoom.Platform.Core.Model.Enums;

namespace Zoom.Platform.Infrastructure.AppContext
{
   public class ZoomPlatformDBContext : DbContext
    {
        public ZoomPlatformDBContext(DbContextOptions<ZoomPlatformDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PreferredPlayGround>().HasKey(sc => new { sc.UserId, sc.PlayGroundId });
            modelBuilder.Entity<PlayGroundBooking>().HasKey(sc => new { sc.UserId, sc.PlayGroundId });
         //   modelBuilder.Entity<AcademyBooking>().HasKey(sc => new { sc.UserId, sc.AcademyId });
         //   modelBuilder.Entity<LeagueBooking>().HasKey(sc => new { sc.UserId, sc.LeagueId });
       //     modelBuilder
      //  .Entity<PlayGround>().Property(p => p.PlaygroundStatus).HasConversion(v => v.ToString(),v => (PlaygroundStatus)Enum.Parse(typeof(PlaygroundStatus), v));
      //      modelBuilder
    //    .Entity<PlayGroundBooking>().Property(p => p.BookinStatus).HasConversion(v => v.ToString(), v => (BookinStatus)Enum.Parse(typeof(BookinStatus), v));
      //     modelBuilder
    //   .Entity<LeagueBooking>().Property(p => p.BookinStatus).HasConversion(v => v.ToString(), v => (BookinStatus)Enum.Parse(typeof(BookinStatus), v));
      //      modelBuilder
   //   .Entity<AcademyBooking>().Property(p => p.BookinStatus).HasConversion(v => v.ToString(), v => (BookinStatus)Enum.Parse(typeof(BookinStatus), v));
        }
   //   public DbSet<Academy> Academies { get; set; }
   //    public DbSet<AcademyBooking> AcademyBookings { get; set; }
   //     public DbSet<AcademyProgram> AcademyPrograms { get; set; }
      public DbSet<Comment> Comments { get; set; }
   //  public DbSet<League> Leagues { get; set; }
   //   public DbSet<LeagueBooking> LeagueBookings { get; set; }
        public DbSet<PlayGround> PlayGrounds { get; set; }
        public DbSet<PlayGroundBooking>  PlayGroundBookings { get; set; }
        public DbSet<PreferredPlayGround>  PreferredPlayGrounds { get; set; }
       public DbSet<Replay>  Replays { get; set; }
        public DbSet<Owner>  Owners { get; set; }
        public DbSet<User>  Users { get; set; }



    }
}
