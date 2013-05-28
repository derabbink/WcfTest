using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfTest.Greeter.Contracts.Service.MepOneWay
{
    /// <summary>
    /// implements a greeter using the One-Way MEP (Message Exchange Pattern)
    /// The client will block until messages are successfully queued/delivered at the server,
    /// but the client does NOT await message processing
    /// </summary>
    [ServiceContract(Name = "MepOneWayGreeter", Namespace = "http://fugro.schemas/wcftest/greeter")]
    public interface IGreeter
    {
        /// <summary>
        /// Caller can say hello
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void SayHello();

        // The One-Way MEP cannot have return types
        //string ExchangeGreetings(string name);

        /// <summary>
        /// Causes the server to throw an exception.
        /// Will NOT be returned to the client
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void CauseError();
    }
}
