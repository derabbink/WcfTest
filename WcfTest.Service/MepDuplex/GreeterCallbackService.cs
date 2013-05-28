using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfTest.Greeter.Contracts.Service.MepDuplex;

namespace WcfTest.Greeter.Service.MepDuplex
{
    public class GreeterCallbackService : IGreeterCallback
    {
        public event EventHandler<AckEventArgs> SayHelloAck;
        public event EventHandler<AckGreetingEventArgs> ExchangeGreetingsAck;
        public event EventHandler<AckEventArgs> CauseErrorAck;

        public void AckSayHello()
        {
            EventHandler<AckEventArgs> handler = SayHelloAck;
            if (handler != null)
                handler(this, new AckEventArgs());
        }

        public void AckExchangeGreetings(string greeting)
        {
            EventHandler<AckGreetingEventArgs> handler = ExchangeGreetingsAck;
            if (handler != null)
                handler(this, new AckGreetingEventArgs(greeting));
        }

        public void AckCauseError()
        {
            EventHandler<AckEventArgs> handler = CauseErrorAck;
            if (handler != null)
                handler(this, new AckEventArgs());
        }

        public class AckEventArgs : EventArgs
        {
        }

        public class AckGreetingEventArgs : EventArgs
        {
            public string Greeting { get; set; }
            public AckGreetingEventArgs(string greeting)
            {
                Greeting = greeting;
            }
        }
    }
}
