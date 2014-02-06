using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using pomoweb.Domain.Entities;
using pomoweb.Domain.Entities.Enums;

namespace pomoweb.Data
{
    public class PomoInitializer : DropCreateDatabaseIfModelChanges<PomodoroModelContext>
    {
        protected override void Seed(PomodoroModelContext context)
        {
            context.Users.Add(
                    new User()
                    {
                        Id = 1,
                        Login = "user1login",
                        Name = "TestUser1",
                        Password = "TestPass",
                        Role = RoleType.Admin,
                        CreatedDateTime = DateTime.Now
                    }
                    );

            context.Categories.Add(
                new Category()
                {
                    Id = 1,
                    Name = "category1",
                    UserId = 1
                }
                );

            context.Pomodoros.Add(
                new Pomodoro()
                {
                    Id = 1,
                    CategoryId = 1,
                    Estimate = 7,
                    UserId = 1,
                    Name = "pomo1"
                });
            context.SaveChanges();
        }
    }
}
