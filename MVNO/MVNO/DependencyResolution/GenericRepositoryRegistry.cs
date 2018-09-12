using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Configuration;
using StructureMap.Pipeline;
using SharpArch.NHibernate;
using SharpArch.Domain.PersistenceSupport;

namespace Telenor.MVNO.Web.DependencyResolution
{
    public class GenericRepositoryRegistry : Registry
    {
        public GenericRepositoryRegistry()
        {
            Scan(x =>
            {
                x.AssemblyContainingType(typeof(IRepository<>));
                x.IncludeNamespace("SharpArch.Domain.PersistenceSupport");

            });
        }
    }
}