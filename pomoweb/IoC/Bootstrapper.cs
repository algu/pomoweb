using System.Web.Mvc;
using Microsoft.Practices.Unity;
using pomoweb.Data.Infrastructure;
using pomoweb.Data.Repositories;
using pomoweb.Domain.Entities;
using pomoweb.Domain.Repositories;
using pomoweb.Domain.Services;
using pomoweb.IoC;
using Unity.Mvc4;

namespace pomoweb
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      
      container.RegisterType<IPomodoroService, PomodoroService>(new HttpContextLifetimeManager<IPomodoroService>());
      container.RegisterType<IRepository<Pomodoro>, PomodoroRepository>(new HttpContextLifetimeManager<IRepository<Pomodoro>>());
      container.RegisterType<IUnitOfWork, UnitOfWork>(new HttpContextLifetimeManager<IUnitOfWork>());
      container.RegisterType<IDatabaseFactory, DatabaseFactory>(new HttpContextLifetimeManager<IDatabaseFactory>());

      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}