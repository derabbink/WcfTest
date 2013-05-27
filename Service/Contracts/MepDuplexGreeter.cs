using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfTest.Service.Contracts
{
    internal partial class MepGreeter : IMepDuplexGreeter
    {
        public void SayHelloDuplex()
        {
            var caller = OperationContext.Current.GetCallbackChannel<IMepDuplexGreeterCallback>();
            caller.AckSayHello();
        }

        public void ExchangeGreetingsDuplex(string name)
        {
            var caller = OperationContext.Current.GetCallbackChannel<IMepDuplexGreeterCallback>();
            caller.AckExchangeGreetings(string.Format("Hello {0} - the MepDuplexGreeter", name));
        }

        public void CauseErrorDuplex()
        {
            throw new Exception("Error was caused in MepDuplexGreeter");
        }
    }
}
