using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.MVNO.Domain.Common
{
    /// <summary>
    /// In order to support collections of value objects we need to be able to give valueObjects a persitence Id
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValueObjectWithPersistenceId<T> : EntityWithTypedId<T>
    {
    }
}
