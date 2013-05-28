using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfTest.Greeter.Contracts.Service.MepDuplex;

namespace WcfTest.Greeter.Service.MepDuplex
{
    public class GreeterService : IGreeter
    {
        public void SayHello()
        {
            var caller = OperationContext.Current.GetCallbackChannel<IGreeterCallback>();
            caller.AckSayHello();
        }

        public void ExchangeGreetings(string name)
        {
            var caller = OperationContext.Current.GetCallbackChannel<IGreeterCallback>();
            caller.AckExchangeGreetings(string.Format("Hello {0} - the MepDuplex.GreeterService", name));
        }

        public void CauseError()
        {
            throw new Exception("Error was caused in MepDuplex.GreeterService");
        }
    }
}
