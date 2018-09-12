using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telenor.MVNO.Domain.Consumptions
{
    public class Amount :ValueObject
    {
        public double Value { get; private set; }
        public Unit Unit { get; private set; }

        protected Amount()
        {

        }

        public Amount(double value, Unit unit)
        {
            Value = value;
            Unit = unit;
        }
    }
}
