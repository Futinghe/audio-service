using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.IO;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            Global.Player = false;
        }

        protected override void OnStop()
        {
        }
        private static System.Media.SoundPlayer thePlayer = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\audio.wav");

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            Program.Refresh();
            if (Global.State == "true" && Global.Player == false)
            {
                thePlayer.PlayLooping();
                Global.Player = true;
            }
            else if (Global.State == "false" && Global.Player == true)
            {
                thePlayer.Stop();
                Global.Player = false;
            }
        }
    }
}
