using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpArch.Domain.PersistenceSupport;

namespace Telenor.MVNO.Domain.Consumptions
{
    public interface IConsumptionRepository : ILinqRepositoryWithTypedId<Consumption, Guid>
    {
    }
}
