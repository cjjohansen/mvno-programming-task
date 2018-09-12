using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telenor.MVNO.Domain.Consumptions;
using Telenor.MVNO.Domain.Subscriptions;

namespace Telenor.MVNO.Infrastructure.NHibernate
{
    public class DatabaseBuilder : IDatabaseBuilder
    {
        private readonly Consumption[] _consumptions = new Consumption[]
                                                        {

                                                                //TODO: Remove code duplication
                                                                new CallConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,12,13,10,0,DateTimeKind.Utc),new DateTime(2014,1,12,13,11,0,DateTimeKind.Utc),false,60, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new CallConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,12,13,20,0,DateTimeKind.Utc),new DateTime(2014,1,12,13,22,0,DateTimeKind.Utc),false,60, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new CallConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,12,13,30,0,DateTimeKind.Utc),new DateTime(2014,1,12,13,33,0,DateTimeKind.Utc),false,60, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new CallConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,12,13,40,0,DateTimeKind.Utc),new DateTime(2014,1,12,13,44,0,DateTimeKind.Utc),false,60, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new CallConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,12,13,50,0,DateTimeKind.Utc),new DateTime(2014,1,12,13,55,0,DateTimeKind.Utc),false,60, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),

                                                                new SMSConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,13,13,10,0,DateTimeKind.Utc),false, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new SMSConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,13,13,20,0,DateTimeKind.Utc),false, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new SMSConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,13,13,30,0,DateTimeKind.Utc),false, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new SMSConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,13,13,40,0,DateTimeKind.Utc),false, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new SMSConsumption(new PhoneNumber("30131514"),new PhoneNumber("70141516"),new DateTime(2014,1,13,13,50,0,DateTimeKind.Utc),false, new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
        
                                                                new DataConsumption(new PhoneNumber("30131514"),new Amount(50.0, Unit.MB), 1,new DateTime(2014,1,14,13,10,0,DateTimeKind.Utc), new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new DataConsumption(new PhoneNumber("30131514"),new Amount(100.0, Unit.MB),1,new DateTime(2014,1,14,13,20,0,DateTimeKind.Utc), new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new DataConsumption(new PhoneNumber("30131514"),new Amount(150.0, Unit.MB),1,new DateTime(2014,1,14,13,30,0,DateTimeKind.Utc), new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new DataConsumption(new PhoneNumber("30131514"),new Amount(200.0, Unit.MB),1,new DateTime(2014,1,14,13,40,0,DateTimeKind.Utc), new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e"))),
                                                                new DataConsumption(new PhoneNumber("30131514"),new Amount(250.0, Unit.MB),1,new DateTime(2014,1,14,13,50,0,DateTimeKind.Utc), new SubscriptionId(new Guid("153a50b1-1c11-4ef2-97b9-671ac820182e")))
                                                        };                                                                                                                                                         


        private readonly IUnitOfWork _unitOfWork;

        public DatabaseBuilder(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void RebuildDatabase()
        {
            CreateInitialData();
        }

        private void CreateInitialData()
        {
            foreach (var consumption in _consumptions)
            {
                _unitOfWork.CurrentSession.Save(consumption);
            }
            _unitOfWork.Commit();
        }

    }
}
