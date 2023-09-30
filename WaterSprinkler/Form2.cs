using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSprinkler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }
        private void Clock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lbl_Clock2.Text = DateTime.Now.ToString("T");
            }));
        }

        private void tmr_Clock2_Tick(object sender, EventArgs e)
        {
            lbl_Clock2.Text = DateTime.Now.ToString("T");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Timers.Timer clock = new System.Timers.Timer();
            clock.Interval = 1000;
            clock.Elapsed += Clock_Elapsed;
            clock.Start();
        }
    }
}
