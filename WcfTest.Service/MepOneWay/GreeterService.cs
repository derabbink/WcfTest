using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfTest.Greeter.Contracts.Service.MepOneWay;

namespace WcfTest.Greeter.Service.MepOneWay
{
    public class GreeterService : IGreeter
    {
        public void SayHello()
        {
            //do nothing
        }

        public void CauseError()
        {
            throw new Exception("Error was caused in MepOneWay.GreeterService");
        }
    }
}
