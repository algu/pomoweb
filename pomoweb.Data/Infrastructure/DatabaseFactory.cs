using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomoweb.Data.Infrastructure
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private PomodoroModelContext dataContext;
        
        public PomodoroModelContext Get()
        {
            return dataContext ?? (dataContext = new PomodoroModelContext());
        }

        //public void Dispose()
        //{
        // if (dataContext!=null)
        //     dataContext.Dispose();
        //}
    }
}
