using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnmain_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Blue)
            {
                btn.Visible = false;
                label2.Text = (int.Parse(label2.Text) - 1).ToString();
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("سوختی؟");
                Close();
            }
            if (label2.Text == "0")
            {
                timer1.Enabled = false;
                MessageBox.Show("برنده شدی");
                Close ();
            }
        }

        private void btnmain_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int numOFblue = 0;
            foreach (Button btn in panel1.Controls)
            {
                if (rdn.Next(0, 2) == 0)
                {
                    btn.BackColor = Color.Blue;
                    numOFblue++;
                }
            }
            label2.Text = numOFblue.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = (int.Parse(label4.Text) + 1).ToString();
        }

        private void button41_Click(object sender, EventArgs e)
        {

        }
    }
}
