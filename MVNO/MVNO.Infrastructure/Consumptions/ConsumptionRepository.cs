using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telenor.MVNO.Domain.Consumptions;
using SharpArch.NHibernate;

namespace Telenor.MVNO.Infrastructure.Consumptions
{
    public class ConsumptionRepository : LinqRepositoryWithTypedId<Consumption,Guid>,  IConsumptionRepository
    {
    }
}
