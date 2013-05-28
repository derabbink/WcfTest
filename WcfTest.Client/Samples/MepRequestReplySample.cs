using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfTest.ClientProxy;
using WcfTest.Greeter.Contracts.Service.MepRequestReply;

namespace WcfTest.Client.Samples
{
    class MepRequestReplySample
    {
        public static void Run()
        {
            // "*" takes the first endpoint configuration that matches the service contract
            ClientFactory<IGreeter> factory = new ClientFactory<IGreeter>("*");

            using (Client<IGreeter> client = factory.GetClient())
            {
                Console.WriteLine("Testing MepRequestReply");
                Console.WriteLine("  .SayHello()");
                client.Channel.SayHello();
                Console.WriteLine("  .ExchangeGreetings(\"MepRequestReplySample\")");
                string result = client.Channel.ExchangeGreetings("MepRequestReplySample");
                Console.WriteLine("    {0}", result);
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

                Console.WriteLine();
            }
        }
    }
}
