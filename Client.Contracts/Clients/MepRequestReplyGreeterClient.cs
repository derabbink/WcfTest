using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Client.Contracts.Clients
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MepRequestReplyGreeterClient : System.ServiceModel.ClientBase<IMepRequestReplyGreeter>, IMepRequestReplyGreeter
    {

        public MepRequestReplyGreeterClient()
        {
        }

        public MepRequestReplyGreeterClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public MepRequestReplyGreeterClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public MepRequestReplyGreeterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public MepRequestReplyGreeterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public void SayHello()
        {
            base.Channel.SayHello();
        }

        public string ExchangeGreetings(string name)
        {
            return base.Channel.ExchangeGreetings(name);
        }

        public void CauseError()
        {
            base.Channel.CauseError();
        }
    }
}
