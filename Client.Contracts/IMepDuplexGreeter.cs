using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Client.Contracts
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://fugro.schemas/wcftest/service", CallbackContract = typeof(IMepDuplexGreeterCallback))]
    public interface IMepDuplexGreeter
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://fugro.schemas/wcftest/service/IMepDuplexGreeter/SayHelloDuplex")]
        void SayHelloDuplex();

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://fugro.schemas/wcftest/service/IMepDuplexGreeter/ExchangeGreetingsDuplex")]
        void ExchangeGreetingsDuplex(string name);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://fugro.schemas/wcftest/service/IMepDuplexGreeter/CauseErrorDuplex")]
        void CauseErrorDuplex();
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMepDuplexGreeterCallback
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://fugro.schemas/wcftest/service/IMepDuplexGreeter/AckSayHello")]
        void AckSayHello();

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://fugro.schemas/wcftest/service/IMepDuplexGreeter/AckExchangeGreetings")]
        void AckExchangeGreetings(string greeting);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://fugro.schemas/wcftest/service/IMepDuplexGreeter/AckCauseError")]
        void AckCauseError();
    }
}
