using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfTest.Greeter.Contracts.Service.MepRequestReply
{
    /// <summary>
    /// implements a greeter using the Request-Reply MEP (Message Exchange Pattern)
    /// The client will block until operations complete
    /// </summary>
    [ServiceContract(Name = "MepRequestReplyGreeter", Namespace = "http://fugro.schemas/wcftest/greeter")]
    public interface IGreeter
    {
        /// <summary>
        /// Caller can say hello
        /// </summary>
        [OperationContract(IsOneWay = false)] //IsOneWay = false is default
        void SayHello();

        /// <summary>
        /// Caller can greet the service and get back a greeting
        /// </summary>
        /// <param name="name">caller's name</param>
        /// <returns>Greeting coming back from service</returns>
        [OperationContract(IsOneWay = false)]
        string ExchangeGreetings(string name);

        /// <summary>
        /// Causes the server to throw an exception.
        /// Will be returned to the client in the SOAP message
        /// </summary>
        [OperationContract(IsOneWay = false)]
        void CauseError();
    }
}
