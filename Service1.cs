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
using System.Net;

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
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadFileAsync(new Uri("http://futinghe.me/assets/audio.wav"), (AppDomain.CurrentDomain.BaseDirectory + @"\audio.wav"));
        }

        protected override void OnStop()
        {
        }

        void Completed(object esender, AsyncCompletedEventArgs e)
        {
            Global.Downloaded = true;
        }

        private static System.Media.SoundPlayer thePlayer = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\audio.wav");

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            Program.Refresh();
            if (Global.State == "true" && Global.Player == false && Global.Downloaded == true)
            {
                thePlayer.PlayLooping();
                Global.Player = true;
            }
            else if (Global.State == "false" && Global.Player == true && Global.Downloaded == true)
            {
                thePlayer.Stop();
                Global.Player = false;
            }
        }
    }
}
