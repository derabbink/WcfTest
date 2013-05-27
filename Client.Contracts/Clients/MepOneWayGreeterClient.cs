using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Client.Contracts.Clients
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MepOneWayGreeterClient : System.ServiceModel.ClientBase<IMepOneWayGreeter>, IMepOneWayGreeter
    {

        public MepOneWayGreeterClient()
        {
        }

        public MepOneWayGreeterClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public MepOneWayGreeterClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public MepOneWayGreeterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public MepOneWayGreeterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public void SayHelloOneWay()
        {
            base.Channel.SayHelloOneWay();
        }

        public void CauseErrorOneWay()
        {
            base.Channel.CauseErrorOneWay();
        }
    }
}
