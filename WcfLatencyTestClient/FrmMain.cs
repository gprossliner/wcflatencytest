using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfLatencyTestClient.ServiceReference1;

namespace WcfLatencyTestClient
{
    public partial class FrmMain : Form
    {
        LatencyTestServiceClient client = new LatencyTestServiceClient();

        Queue<TimeSpan> currentDelays = new Queue<TimeSpan>();
        int burstsOutstanding;
        int total;
        int paralell;

        Random rnd = new Random();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            client.Sync(TimeSpan.FromTicks(Stopwatch.GetTimestamp()));
            var thread = new Thread(ShortOpsThread);
            thread.Name = "ShortOpsThread";
            thread.IsBackground = true;
            thread.Start();
            timRefreshLabel.Start();

            cmdStart.Enabled = false;
        }

        void ShortOpsThread()
        {
            var sleepTime = TimeSpan.FromMilliseconds(100);

            for (; ; )
            {
                var sw = new Stopwatch();
                sw.Start();
                RunOperation(sleepTime);
                sw.Stop();

                var delay = sw.Elapsed - sleepTime;
                lock (currentDelays)
                {
                    currentDelays.Enqueue(delay);
                }

            }
        }

        private void RunOperation(TimeSpan sleepTime)
        {
            Interlocked.Increment(ref total);
            Interlocked.Increment(ref paralell);

            client.Operation(sleepTime, TimeSpan.FromTicks(Stopwatch.GetTimestamp()));
            Interlocked.Decrement(ref paralell);
        }

        private void timRefreshLabel_Tick(object sender, EventArgs e)
        {
            var average = default(TimeSpan);
            lock (currentDelays)
            {
                if (currentDelays.Any())
                {
                    average = TimeSpan.FromMilliseconds(currentDelays.Average(ts => ts.TotalMilliseconds));

                    // let the last 5 values listed, to get a floating average
                    while(currentDelays.Count > 5)
                    {
                        currentDelays.Dequeue();
                    }
                }

            }

            lblDelay.Text = $"Current Delay: {average}";
            lblTotalRequests.Text = $"Total Requests: {total}";
            lblParallel.Text = $"Parallel Requests: {paralell}";

            lblBurstOutstanding.Text = $"Bursts Outstanding: {burstsOutstanding}";
        }

        private void cmdBurst_Click(object sender, EventArgs e)
        {
            for(var i=0; i<nudBurstCount.Value; i++)
            {
                var thread = new Thread(BurstThread);
                thread.IsBackground = true;
                thread.Name = "BurstThread";
                thread.Start();
            }
        }
        
        void BurstThread()
        {

            // to get better output, don't let them all start at once
            Thread.Sleep(rnd.Next(100, 1000));

            Interlocked.Increment(ref burstsOutstanding);
            RunOperation(TimeSpan.FromSeconds((int)nudBurstDelay.Value));
            Interlocked.Decrement(ref burstsOutstanding);
        }
    }
}
