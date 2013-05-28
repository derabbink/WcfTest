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
            Callback.AckSayHello();
        }

        public void ExchangeGreetings(string name)
        {
            Callback.AckExchangeGreetings(string.Format("Hello {0} - the MepDuplex.GreeterService", name));
        }

        public void CauseError()
        {
            throw new Exception("Error was caused in MepDuplex.GreeterService");
        }

        IGreeterCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IGreeterCallback>();
            }
        }
    }
}
