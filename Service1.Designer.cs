
namespace WindowsService1
{
    partial class Service1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timer2 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000D;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // Service1
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();

        }

        #endregion
        private System.Timers.Timer timer2;
    }
}
