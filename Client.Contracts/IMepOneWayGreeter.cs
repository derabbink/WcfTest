using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Client.Contracts
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://fugro.schemas/wcftest/service")]
    public interface IMepOneWayGreeter
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://fugro.schemas/wcftest/service/IMepOneWayGreeter/SayHelloOneWay")]
        void SayHelloOneWay();

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://fugro.schemas/wcftest/service/IMepOneWayGreeter/CauseErrorOneWay")]
        void CauseErrorOneWay();
    }
}
