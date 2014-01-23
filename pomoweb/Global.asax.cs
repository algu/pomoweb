using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using pomoweb.Data;
using pomoweb.Domain.Entities;
using pomoweb.Domain.Entities.Enums;

namespace pomoweb
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //uncomment line below if you want to recreate DB everytime when model change
            //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<PomodoroModelContext>());

            var dbContext = new PomodoroModelContext();
            dbContext.Database.Initialize(false);
            //Init_db(dbContext);
        }

        public void Init_db(PomodoroModelContext db)
        {
            db.Users.Add(
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

            db.Categories.Add(
                new Category()
                {
                    Id = 1,
                    Name = "category1",
                    UserId = 1
                }
                );

            db.Pomodoros.Add(
                new Pomodoro()
                {
                    Id = 1,
                    CategoryId = 1,
                    Estimate = 7,
                    UserId = 1,
                    Name = "pomo1"
                });
            db.SaveChanges();           
        }
    }
}