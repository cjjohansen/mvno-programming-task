using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telenor.MVNO.Domain.Consumptions;
using Telenor.MVNO.Infrastructure.Consumptions;

namespace Telenor.MVNO.Web.DependencyResolution
{
    public class CustomRepositoryRegistry : Registry
    {
        public CustomRepositoryRegistry()
        {
            Scan(x =>
            {
                x.AssemblyContainingType(typeof(ConsumptionRepository));
                x.IncludeNamespace("Telenor.MVNO.Infrastructure");
                x.SingleImplementationsOfInterface();

            });

        }
    }
}