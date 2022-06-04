using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CUTimer : UserControl
    {
        private int interval = 100;
        private int stopAt = 0;
        private bool isEnable = true;
        public EventHandler onStop;
        public CUTimer()
        {
            InitializeComponent();
        }

        public bool IsEnable { get => isEnable; set => isEnable = value; }
        public int Interval { get => interval; set => interval = value; }
        public int StopAt { get => stopAt; set => stopAt = value; }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(interval >= stopAt && isEnable==true)
            {
                lblCount.Text = interval.ToString();
                interval--;
            }
            else if (interval == stopAt && isEnable == true)
            {
                isEnable = false;
                onStop?.Invoke(sender, EventArgs.Empty);
            }
        }
    }
}
