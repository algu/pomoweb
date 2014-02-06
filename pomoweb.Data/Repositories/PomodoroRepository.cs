using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pomoweb.Data.Infrastructure;
using pomoweb.Domain.Entities;
using pomoweb.Domain.Repositories;

namespace pomoweb.Data.Repositories
{
    public class PomodoroRepository : BaseRepository<Pomodoro>, IRepository<Pomodoro>
    {
        public PomodoroRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }

    public interface IPomodoroRepository 
    {
         
    }
}
