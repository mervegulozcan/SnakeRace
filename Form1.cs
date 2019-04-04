using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanYarisi
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            pictureBox1.Left = 3;
            pictureBox2.Left = 3;
            timer1.Start();
            timer1_Tick(sender,e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.Left = pictureBox1.Left + rnd.Next(1, 15);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(1, 15);
            if (pictureBox1.Right >= label1.Left || pictureBox2.Right >= label1.Left)
            {
                timer1.Stop();
                string kazanan;
                if(pictureBox1.Right>=pictureBox2.Right)
                {
                    kazanan = "Sarı Yılan";
                }
                else
                {
                    kazanan = "Yeşil Yılan";
                }
                MessageBox.Show($"{kazanan} kazandı.");

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
