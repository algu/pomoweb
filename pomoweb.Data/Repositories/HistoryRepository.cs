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
    public class HistoryBaseRepository : BaseRepository<History>, IRepository<History>
    {
        public HistoryBaseRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
