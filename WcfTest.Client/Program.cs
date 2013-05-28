using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfTest.Client.Samples;

namespace WcfTest.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The client will now execute sample programs.");
            Console.WriteLine();

            MepRequestReplySample.Run();
            MepOneWaySample.Run();
            MepDuplexSample.Run();

            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();
        }
    }
}
