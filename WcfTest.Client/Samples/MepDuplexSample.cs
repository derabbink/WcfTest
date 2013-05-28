using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using WcfTest.ClientProxy;
using WcfTest.Greeter.Contracts.Service.MepDuplex;
using WcfTest.Greeter.Service.MepDuplex;

namespace WcfTest.Client.Samples
{
    class MepDuplexSample
    {
        public static void Run()
        {
            var callbackHandler = new GreeterCallbackService();
            // "*" takes the first endpoint configuration that matches the service contract
            DuplexClientFactory<IGreeter, IGreeterCallback> factory = new DuplexClientFactory<IGreeter, IGreeterCallback>("*", callbackHandler);

            //observables for easy waiting for ack events
            IObservable<Unit> sayHelloAcks = Observable.FromEventPattern<GreeterCallbackService.AckEventArgs>(x => callbackHandler.SayHelloAck += x,
                                                                                                x => callbackHandler.SayHelloAck -= x).Select(ep => new Unit());
            IObservable<String> exchangeGreetingsAck = Observable.FromEventPattern<GreeterCallbackService.AckGreetingEventArgs>(x => callbackHandler.ExchangeGreetingsAck += x,
                                                                                                                x => callbackHandler.ExchangeGreetingsAck -= x).Select(ep => ep.EventArgs.Greeting);
            IObservable<Unit> causeErrorAck = Observable.FromEventPattern<GreeterCallbackService.AckEventArgs>(x => callbackHandler.CauseErrorAck += x,
                                                                                                 x => callbackHandler.CauseErrorAck -= x).Select(ep => new Unit());
            
            using (Client<IGreeter> client = factory.GetClient())
            {
                Console.WriteLine("Testing MepDuplex");
                Console.WriteLine("  .SayHello()");
                client.Channel.SayHello();
                sayHelloAcks.First();
                
                Console.WriteLine("  .ExchangeGreetings(\"MepDuplexSample\")");
                client.Channel.ExchangeGreetings("MepDuplexSample");
                var greeting = exchangeGreetingsAck.First();
                Console.WriteLine("    got back greeting: {0}", greeting);
                
                Console.WriteLine("  .CauseError()");
                try
                {
                    client.Channel.CauseError();
                    Console.WriteLine("    No exception caught in client.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("    caught exception in client: {0}", e.Message);
                }
                //this ack will never come, so we don't wait for it
                //causeErrorAck.First();

                Console.WriteLine();
            }
        }
    }
}
