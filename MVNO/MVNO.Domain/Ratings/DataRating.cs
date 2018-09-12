using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telenor.MVNO.Domain.Consumptions;

namespace Telenor.MVNO.Domain.Ratings
{
    public class DataRating : Rating
    {
       


        public DataRating(Decimal unitPrice) : base(unitPrice)
        {

        }


        /// <summary>
        /// Robert Martin actually suggests to put error handling in another method. Lets do that.
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public override decimal Rate(Consumption consumption)
        {
            if (!(consumption is DataConsumption))
                throw new ArgumentException("consumption has to be of type DataConsumption", "consumption");

            DataConsumption dataConsumption = (DataConsumption)consumption;
          
            try{
               
                return DivideConsumptionByUnitSizeAndMultiplyWithUnitPrice(dataConsumption);
            }
            catch(DivideByZeroException dbze)
            {
                //handle specífic exception here. (We have actually guarded against UnitSize being zero.
                throw dbze;
            }
            catch(Exception ex) // We might consider narrowing the scope of exceptions
            {
                //TODO: log exception, or handle it or just rethrow it. 
                throw ex;
            }
           
        }


        /// <summary>
        /// Errorhandling is handled in calling method
        /// </summary>
        /// <param name="dataConsumption"></param>
        /// <returns></returns>
        protected decimal DivideConsumptionByUnitSizeAndMultiplyWithUnitPrice(DataConsumption dataConsumption )
        {
            var result = ((decimal)dataConsumption.Amount.Value / dataConsumption.UnitSize) * UnitPrice;
            return result;

        }

        public override bool CanRate(Consumption consumption)
        {
            if (consumption is DataConsumption)
                return true;
            return false;
        }
    }
}
