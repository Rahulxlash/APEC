using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using APEC.DOMAIN.Repository;
using APEC.DOMAIN.Infrastructure;

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
      container.RegisterType<IDatabaseFactory, DatabaseFactory>();
      container.RegisterType<IDistrictRepository, DistrictRepository>();
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}