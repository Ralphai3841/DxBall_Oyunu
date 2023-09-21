using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxBall_Oyunu
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            PcbRaket.Top = PnlOyunAlanı.Bottom - (PnlOyunAlanı.Bottom / 10);
        }
        int a = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PcbRaket.Left = Cursor.Position.X - (PcbRaket.Width / 2);
            PcbTop.Left += speed_left;
            PcbTop.Top += speed_top;

            if (PcbTop.Bottom >= PcbRaket.Top && PcbTop.Bottom <= PcbRaket.Bottom && PcbTop.Left >= PcbRaket.Left && PcbTop.Right >= PcbRaket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_left;
                point += 1;
            }
            if (PcbTop.Left <= PnlOyunAlanı.Left)
            {
                speed_left = -speed_left;
            } 
            if (PcbTop.Right >= PnlOyunAlanı.Right)
            {
                speed_left = -speed_left;
            }
            if (PcbTop.Top <= PnlOyunAlanı.Top)
            {
                speed_top = -speed_top;
            }
            if (PcbTop.Bottom >= PnlOyunAlanı.Bottom)
            {
                timer1.Enabled = false;
            }
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (PcbTop.Top <= pictureBox6.Bottom && PcbTop.Bottom >= pictureBox6.Top && PcbTop.Left <= pictureBox6.Right && PcbTop.Right >= pictureBox6.Left)
            {
                pictureBox6.Visible = false; a++; pictureBox6.Top = 1500;
            }
            if (PcbTop.Top <= pictureBox5.Bottom && PcbTop.Bottom >= pictureBox5.Top && PcbTop.Left <= pictureBox5.Right && PcbTop.Right >= pictureBox5.Left)
            {
                pictureBox5.Visible = false; a++; pictureBox5.Top = 1500;
            } 
            if (PcbTop.Top <= pictureBox4.Bottom && PcbTop.Bottom >= pictureBox4.Top && PcbTop.Left <= pictureBox4.Right && PcbTop.Right >= pictureBox4.Left)
            {
                pictureBox4.Visible = false; a++; pictureBox4.Top = 1500;
            } 
            if (PcbTop.Top <= pictureBox3.Bottom && PcbTop.Bottom >= pictureBox3.Top && PcbTop.Left <= pictureBox3.Right && PcbTop.Right >= pictureBox3.Left)
            {
                pictureBox3.Visible = false; a++; pictureBox3.Top = 1500;
            }
            if (PcbTop.Top <= pictureBox2.Bottom && PcbTop.Bottom >= pictureBox2.Top && PcbTop.Left <= pictureBox2.Right && PcbTop.Right >= pictureBox2.Left)
            {
                pictureBox2.Visible = false; a++; pictureBox2.Top = 1500;
            }
            if (PcbTop.Top <= pictureBox1.Bottom && PcbTop.Bottom >= pictureBox1.Top && PcbTop.Left <= pictureBox1.Right && PcbTop.Right >= pictureBox1.Left)
            {
                pictureBox1.Visible = false; a++; pictureBox1.Top = 1500;
            }
            if (a==6)
            {
                timer1.Stop();
                label1.Visible = true;
            }
            if (PcbTop.Top >= PcbRaket.Top)
            {
                timer1.Stop();
                label2.Visible = true;
            }
            label3.Text = "" + a;
        }
    }
}
