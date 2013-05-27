using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Client.Contracts
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://fugro.schemas/wcftest/service")]
    public interface IMepRequestReplyGreeter
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://fugro.schemas/wcftest/service/IMepRequestReplyGreeter/SayHello", ReplyAction = "http://fugro.schemas/wcftest/service/IMepRequestReplyGreeter/SayHelloResponse")]
        void SayHello();

        [System.ServiceModel.OperationContractAttribute(Action = "http://fugro.schemas/wcftest/service/IMepRequestReplyGreeter/ExchangeGreetings", ReplyAction = "http://fugro.schemas/wcftest/service/IMepRequestReplyGreeter/ExchangeGreetingsResponse")]
        string ExchangeGreetings(string name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fugro.schemas/wcftest/service/IMepRequestReplyGreeter/CauseError", ReplyAction = "http://fugro.schemas/wcftest/service/IMepRequestReplyGreeter/CauseErrorResponse")]
        void CauseError();
    }
}
