using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text + "버튼이 클릭되었습니다.");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text + "버튼이 클릭되었습니다.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer2.Enabled = false;
            MessageBox.Show(e.CloseReason.ToString());
        }

        // 지난 시간
        private int elapsedTime = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox2.Text = elapsedTime.ToString();
            label2.Text = elapsedTime + "초 경과";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // 작동 유무
            timer2.Enabled = !timer2.Enabled;
            if (timer2.Enabled)
            {
                button6.Text = "Stop";
            }
            else
            {
                button6.Text = "Start";
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }

}
