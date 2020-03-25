using Microsoft.EntityFrameworkCore;
using Stream.Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stream.Schedule.Data
{
    public class StreamDbContext : DbContext
    {

        public StreamDbContext(DbContextOptions<StreamDbContext> options) : base(options)
        {
        }

        public DbSet<ScheduleItem> Schedules { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScheduleItem>().ToTable("ScheduleItems");
        }
    }
}
