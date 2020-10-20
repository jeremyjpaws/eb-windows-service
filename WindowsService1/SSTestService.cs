// Copyright 2019 Amazon.com
// SPDX-License-Identifier: Apache-2.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;



namespace WindowsService1
{
    public partial class SSTestService : ServiceBase
    {
        private readonly EventLog eventLog1;
        //private int eventId = 0;

        public SSTestService()
        {
            InitializeComponent();
            eventLog1 = new EventLog();
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("SS test service starting...");
            // Set up a timer that triggers every minute.
            Timer timer = new Timer();
            timer.Interval = 60000; // 60 seconds
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            eventLog1.WriteEntry("SS test service continuing to run...");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Stopping SS test service...");
        }

        
    }
}
