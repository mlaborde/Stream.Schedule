using Stream.Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stream.Schedule.Data
{
    public static class DbInitializer
    {

        public static void Initialize(StreamDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Schedules.Any())
            {
                return;   // DB has been seeded
            }

            var schedules = new ScheduleItem[]
            {
            new ScheduleItem{Title ="Entrando en calor",From=DateTime.Parse("2020-03-20 21:00"),To=DateTime.Parse("2020-03-20 21:30")},
            new ScheduleItem{Title ="Desafío del día: PUBG LITE - 5 kills con escopeta o pistola",From=DateTime.Parse("2020-03-20 21:30"),To=DateTime.Parse("2020-03-20 23:00")},
            new ScheduleItem{Title ="Elige la gente!!",From=DateTime.Parse("2020-03-20 23:00"),To=DateTime.Parse("2020-03-21 00:00")}
            };
            foreach (ScheduleItem s in schedules)
            {
                context.Schedules.Add(s);
            }
            context.SaveChanges();
        }
    }
}
