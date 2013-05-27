using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Client.Contracts.Clients
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MepDuplexGreeterClient : System.ServiceModel.DuplexClientBase<IMepDuplexGreeter>, IMepDuplexGreeter
    {

        public MepDuplexGreeterClient(System.ServiceModel.InstanceContext callbackInstance) :
            base(callbackInstance)
        {
        }

        public MepDuplexGreeterClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) :
            base(callbackInstance, endpointConfigurationName)
        {
        }

        public MepDuplexGreeterClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) :
            base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public MepDuplexGreeterClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public MepDuplexGreeterClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(callbackInstance, binding, remoteAddress)
        {
        }

        public void SayHelloDuplex()
        {
            base.Channel.SayHelloDuplex();
        }

        public void ExchangeGreetingsDuplex(string name)
        {
            base.Channel.ExchangeGreetingsDuplex(name);
        }

        public void CauseErrorDuplex()
        {
            base.Channel.CauseErrorDuplex();
        }
    }
}
