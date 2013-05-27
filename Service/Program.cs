using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfTest.Service.Contracts;

namespace WcfTest.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a ServiceHost for the MepGreeter type.
            using (ServiceHost serviceHost = new ServiceHost(typeof(MepGreeter)))
            {
                // Open the ServiceHost to create listeners and start listening for messages.
                serviceHost.Open();

                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.ReadLine();
            }
        }
    }
}
