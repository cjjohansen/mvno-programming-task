using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telenor.MVNO.Domain.Subscriptions
{
    public class PersonName : ValueObject
    {
        
        /// <summary>
        /// Force usage of parameterized constructor
        /// </summary>
        protected PersonName()
        {

        }
        public PersonName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        /// <summary>
        /// Create pretty string of full name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName,LastName);
        }

    }
}
