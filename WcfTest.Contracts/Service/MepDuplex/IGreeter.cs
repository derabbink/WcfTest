using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfTest.Greeter.Contracts.Service.MepDuplex
{
    /// <summary>
    /// implements a greeter using the Duplex MEP (Message Exchange Pattern)
    /// This uses two One-Way MEP interfaces, one for client-to-server and one for callbacks (server-to-client)
    /// </summary>
    [ServiceContract(Name = "MepDuplexGreeter", Namespace = "http://fugro.schemas/wcftest/greeter", CallbackContract = typeof(IGreeterCallback))]
    public interface IGreeter
    {
        /// <summary>
        /// Caller can say hello and receives a message processing ack,
        /// through callback
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void SayHello();

        /// <summary>
        /// Caller can greet the service and get back a greeting, through callback
        /// </summary>
        /// <param name="name">caller's name</param>
        [OperationContract(IsOneWay = true)]
        void ExchangeGreetings(string name);

        /// <summary>
        /// Causes the server to throw an exception.
        /// Will be returned to the client through callback
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void CauseError();
    }

    public interface IGreeterCallback
    {
        /// <summary>
        /// Processes incoming ack from preceeding outgoing SayHello message
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void AckSayHello();

        /// <summary>
        /// Processes incoming greeting from preceeding outgoing ExchangeGreetings message
        /// </summary>
        /// <param name="greeting"></param>
        [OperationContract(IsOneWay = true)]
        void AckExchangeGreetings(string greeting);

        /// <summary>
        /// processes incoming error from preceeding outgoing CauseError message
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void AckCauseError();
    }
}
