using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WcfLatencyTest {
    using System.Diagnostics;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.Threading;

    [ServiceContract]
    public interface ILatencyTestService {

        [OperationContract]
        void Sync(TimeSpan clientTimestamp);

        [OperationContract]
        TimeSpan Operation(TimeSpan delay, TimeSpan clientTimestamp);

    }

    public class LatencyTestService : ILatencyTestService {

        int currentOperations = 0;
        TimeSpan clientTimestampOffset;

        void ILatencyTestService.Sync(TimeSpan clientTimestamp) {
            clientTimestampOffset = TimeSpan.FromTicks(Stopwatch.GetTimestamp() - clientTimestamp.Ticks);
            Console.WriteLine($"SYNC idleLatency={clientTimestampOffset}");
        }
        
        TimeSpan ILatencyTestService.Operation(TimeSpan delay, TimeSpan clientTimestamp) {

            // this will only yield correct results, if Server and Client are on the same maschine
            var acceptLatency = TimeSpan.FromTicks(Stopwatch.GetTimestamp()) - clientTimestamp + clientTimestampOffset;

            Console.WriteLine($"START accptLat={acceptLatency, 8} cops={Interlocked.Increment(ref currentOperations), 3} ");
            
            var sw = new Stopwatch();
            sw.Start();
            Thread.Sleep((int)delay.TotalMilliseconds);
            sw.Stop();

            Console.WriteLine($"FINSH duration={sw.Elapsed,8} cops={Interlocked.Decrement(ref currentOperations), 3}");

            return sw.Elapsed;
        }
        
    }

    class Server {
        static void Main(string[] args) {
            
            var baseAddress = new Uri("http://localhost:6666/lantencyTestService");
            using (var host = new ServiceHost(typeof(LatencyTestService), baseAddress)) {

                // Enable metadata publishing.
                var smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

            }

        }
    }
}
