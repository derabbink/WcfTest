using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfTest.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a ServiceHost for the all the Greeter types.
            ServiceHost duplexGreeterHost = new ServiceHost(typeof(Greeter.Service.MepDuplex.GreeterService));
            ServiceHost onewayGreeterHost = new ServiceHost(typeof(Greeter.Service.MepOneWay.GreeterService));
            ServiceHost reqrepGreeterHost = new ServiceHost(typeof(Greeter.Service.MepRequestReply.GreeterService));

            // Open the ServiceHosts to create listeners and start listening for messages.
            duplexGreeterHost.Open();
            Console.WriteLine("The MepDuplex.GreeterService is ready.");
            onewayGreeterHost.Open();
            Console.WriteLine("The MepOneWay.GreeterService is ready.");
            reqrepGreeterHost.Open();
            Console.WriteLine("The MepRequestReply.GreeterService is ready.");

            Console.WriteLine("Press <ENTER> to terminate services.");
            Console.ReadLine();

            duplexGreeterHost.Close();
            onewayGreeterHost.Close();
            reqrepGreeterHost.Close();
        }
    }
}
