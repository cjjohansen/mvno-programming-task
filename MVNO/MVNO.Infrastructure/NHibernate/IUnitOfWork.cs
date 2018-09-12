using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace Telenor.MVNO.Infrastructure.NHibernate
{
         public interface IUnitOfWork : IDisposable
        {
            ISession CurrentSession { get; }
            void Commit();
            void Rollback();
        }
  
}
