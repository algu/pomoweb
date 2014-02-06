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
    public class UserBaseRepository : BaseRepository<User>, IRepository<User>
    {
        public UserBaseRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
