using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomoweb.Data.Infrastructure
{
    public interface IDatabaseFactory 
    {
        PomodoroModelContext Get();
    }
}
