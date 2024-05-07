using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace 倒數計時器
{
    public partial class Form1 : Form
    {

        private int count = 100;
        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 設定計時器間隔為1秒
            timer.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            label1.Text = count.ToString();
            if (count <= 0)
            {
                timer.Stop();
                MessageBox.Show("時間到!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer.Interval = 1000;
        }
    }
}