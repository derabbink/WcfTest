using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfTest.ClientProxy
{
    /// <summary>
    /// Wrapper class for WCF duplex channel that can disposed of without throwing exeptions
    /// </summary>
    /// <typeparam name="T">service contract type</typeparam>
    /// <typeparam name="U">callback service contract type</typeparam>
    public class DuplexClient<T, U> : IDisposable
    {
        public T Channel { get; private set; }

        public DuplexClient(T channel, U callbackHandler)
        {
            Channel = channel;

            // Construct InstanceContext to handle messages on callback interface
            InstanceContext instanceContext = new InstanceContext(callbackHandler);

            // Create a client
            //CalculatorDuplexClient client = new CalculatorDuplexClient(instanceContext);
        }

        public void Dispose()
        {
            //Dispose() on ICommunicationObject can throw
            var channel = Channel as ICommunicationObject;
            try
            {
                channel.Close();
            }
            catch (CommunicationException)
            {
                channel.Abort();
            }
            catch (TimeoutException)
            {
                channel.Abort();
            }
        }
    }
}
