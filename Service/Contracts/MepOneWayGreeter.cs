using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Service.Contracts
{
    internal partial class MepGreeter : IMepOneWayGreeter
    {
        public void SayHelloOneWay()
        {
            //do nothing
        }

        public void CauseErrorOneWay()
        {
            throw new Exception("Error was caused in MepOneWayGreeter");
        }
    }
}
