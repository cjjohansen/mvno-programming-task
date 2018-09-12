using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.MVNO.Infrastructure.NHibernate
{
    public interface IDatabaseBuilder
    {
        void RebuildDatabase();
    }
}
