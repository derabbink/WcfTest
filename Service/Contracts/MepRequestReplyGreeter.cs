using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Service.Contracts
{
    internal partial class MepGreeter : IMepRequestReplyGreeter
    {
        public void SayHello()
        {
            //do nothing
        }

        public string ExchangeGreetings(string name)
        {
            return string.Format("Hello {0} - the MepRequestReplyGreeter", name);
        }

        public void CauseError()
        {
            throw new Exception("Error was caused in MepRequestReplyGreeter");
        }
    }
}
