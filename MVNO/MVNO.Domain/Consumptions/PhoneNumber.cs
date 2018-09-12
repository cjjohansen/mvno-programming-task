using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telenor.MVNO.Domain.Consumptions
{
    /// <summary>
    /// Represents a phone number
    /// </summary>
    public class PhoneNumber : ValueObject
    {
        protected PhoneNumber()
        {

        }

        public PhoneNumber(string phoneNumber)
        {
            //Todo: Add validation. Make sure that country code is included in number.
            //We can find some regex expression.
            Number = phoneNumber;

        }


        public String Number
        {
            get;
            
            set;
           
        }

        public string CountryCode
        {
            get
            {
                //Todo: Naive implementation. 
                return Number.Substring(0, 2); 
            }
            
        }
    }
}
