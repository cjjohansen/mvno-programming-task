using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Configuration;
using StructureMap.Pipeline;


namespace Telenor.MVNO.Web.DependencyResolution
{
    public class StructureMapRegistry : Registry
    {


        public StructureMapRegistry()
        {
            //ForRequestedType<IConsumptionService>()
            //   .TheDefaultIsConcreteType<ConsumptionService>();
            //ForRequestedType<ISubscriberServiceCategoryRepository>()
            //   .TheDefaultIsConcreteType<CategoryRepository>();
        }

    }
}

