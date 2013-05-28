using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfTest.Greeter.Contracts.Service.MepRequestReply;

namespace WcfTest.Greeter.Service.MepRequestReply
{
    public class GreeterService : IGreeter
    {
        public void SayHello()
        {
            //do nothing
        }

        public string ExchangeGreetings(string name)
        {
            return string.Format("Hello {0} - the MepRequestReply.GreeterService", name);
        }

        public void CauseError()
        {
            throw new Exception("Error was caused in MepRequestReply.GreeterService");
        }
    }
}
