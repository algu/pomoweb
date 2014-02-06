using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pomoweb.Domain.Entities;
using pomoweb.Domain.Entities.Enums;


namespace pomoweb.Data
{
    public class PomodoroModelContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pomodoro> Pomodoros { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Category> Categories { get; set; }

        //public PomodoroModelContext()
        //{
        //    Database.SetInitializer(new PomoInitializer());
        //}
    }

}
