using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;

namespace Telenor.MVNO.Web.DependencyResolution
{
    public class StructureMapBootStrapper : IBootstrapper
    {
        private static bool _hasStarted;

        public void BootstrapStructureMap()
        {


            ObjectFactory.Initialize(x =>
           {
               // We put the properties for an NHibernate ISession
               // in the StructureMap.config file, so this file
               // must be there for our application to
               // function correctly
               //x.UseDefaultStructureMapConfigFile = true;
               x.AddRegistry(new NHibernateRegistry());
               x.AddRegistry(new GenericRepositoryRegistry());
               x.AddRegistry(new CustomRepositoryRegistry());
               x.AddRegistry(new FactoryRegistry());
               x.AddRegistry(new QueryRegistry());
           });
        }

        public static void Restart()
        {
            if (_hasStarted)
            {
                ObjectFactory.ResetDefaults();
            }
            else
            {
                Bootstrap();
                _hasStarted = true;
            }
        }

        public static void Bootstrap()
        {
            new StructureMapBootStrapper().BootstrapStructureMap();
        }
    }
}



