using System.Web.Mvc;
using Microsoft.Practices.Unity;
//using Unity.Mvc;
using APEC.DOMAIN.Repository;
using APEC.DOMAIN.Infrastructure;
using APEC.Controllers;
using Microsoft.Practices.Unity.Mvc;

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
      container.RegisterType<IUnitofWork, UnitofWork>(new PerRequestLifetimeManager());
      container.RegisterType<IDatabaseFactory, DatabaseFactory>(new PerRequestLifetimeManager());
      container.RegisterType<IDistrictRepository, DistrictRepository>(new PerRequestLifetimeManager());
      container.RegisterType<IClientRepository, ClientRepository>(new PerRequestLifetimeManager());
      container.RegisterType<IBlockRepository, BlockRepository>(new PerRequestLifetimeManager());

      container.RegisterType<AccountController>(new InjectionConstructor());
      container.RegisterType<ManageController>(new InjectionConstructor());
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}