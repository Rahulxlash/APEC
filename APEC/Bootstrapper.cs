using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using APEC.DOMAIN.Repository;
using APEC.DOMAIN.Infrastructure;
using APEC.Controllers;

namespace APEC
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
      container.RegisterType<IUnitofWork, UnitofWork>(new PerThreadLifetimeManager());
      container.RegisterType<IDatabaseFactory, DatabaseFactory>(new PerThreadLifetimeManager());
      container.RegisterType<IDistrictRepository, DistrictRepository>(new PerThreadLifetimeManager());

      //container.RegisterType<AccountController>(new InjectionConstructor());
      //container.RegisterType<ManageController>(new InjectionConstructor());
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}