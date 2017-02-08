using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((i % 2) == 1)
            {
                // button1.Location = new Point(button1.Location.X - 250, button1.Location.Y);
                // button2.Location = new Point(button2.Location.X - 250, button2.Location.Y);
                // button3.Location = new Point(button3.Location.X - 250, button3.Location.Y);
                // button4.Location = new Point(button4.Location.X - 250, button4.Location.Y);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                //tableLayoutPanel1.Location = new Point(tableLayoutPanel1.Location.X - 80, tableLayoutPanel1.Location.Y);
                tableLayoutPanel1.Visible = true;

            }
            else
            {
                //button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
                //button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
                //button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
                //button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                //tableLayoutPanel1.Location = new Point(tableLayoutPanel1.Location.X + 80, tableLayoutPanel1.Location.Y);
                tableLayoutPanel1.Visible = false;
            }
            i++;
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "800x600")
            {
              this.Size = new Size(800,600);
            }
            if (comboBox1.Text == "1280x1024")
            {
                this.Size = new Size(1280, 1024);
                button1.Location = new Point(button1.Location.X + 100, button1.Location.Y);
                button2.Location = new Point(button2.Location.X + 100, button2.Location.Y);
                button3.Location = new Point(button3.Location.X + 100, button3.Location.Y);
                button4.Location = new Point(button4.Location.X + 100, button4.Location.Y);
            }
            if (comboBox1.Text == "1024x768")
            {
                this.Size = new Size(1024, 768);
            }
            if (comboBox1.Text == "1280x720")
            {
                this.Size = new Size(1280, 720);
            }
            if (comboBox1.Text == "1920x1080")
            {
                this.Size = new Size(1920, 1080);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                button1.Location = new Point(button1.Location.X + 100, button1.Location.Y + 100);
                button2.Location = new Point(button2.Location.X + 100, button2.Location.Y + 100);
                button3.Location = new Point(button3.Location.X + 100, button3.Location.Y + 100);
                button4.Location = new Point(button4.Location.X + 100, button4.Location.Y + 100);

                tableLayoutPanel1.Location = new Point(tableLayoutPanel1.Location.X + 150, tableLayoutPanel1.Location.Y + 150);
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X, flowLayoutPanel1.Location.Y + 100);
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                button1.Location = new Point(button1.Location.X - 100, button1.Location.Y - 100);
                button2.Location = new Point(button2.Location.X - 100, button2.Location.Y - 100);
                button3.Location = new Point(button3.Location.X - 100, button3.Location.Y - 100);
                button4.Location = new Point(button4.Location.X - 100, button4.Location.Y - 100);
                tableLayoutPanel1.Location = new Point(tableLayoutPanel1.Location.X - 150, tableLayoutPanel1.Location.Y - 150);
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X, flowLayoutPanel1.Location.Y - 100);
            }
        }
        int t = 1;
        SoundPlayer but = new SoundPlayer("C:\\Users\\Dmitrii\\documents\\visual studio 2015\\Projects\\GameTest\\GameTest\\Resources\\kn.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            but.Play();
            if ((t % 2) == 1)
            {
                button1.Location = new Point(button1.Location.X - 250, button1.Location.Y);
                button2.Location = new Point(button2.Location.X - 250, button2.Location.Y);
                button2.Enabled = false;
                button3.Location = new Point(button3.Location.X - 250, button3.Location.Y);
                button3.Enabled = false;
                button4.Location = new Point(button4.Location.X - 250, button4.Location.Y);
                button4.Enabled = false;
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X - 150, flowLayoutPanel1.Location.Y);
                flowLayoutPanel1.Visible = true;
                pictureBox1.Enabled = false;
                

            }
            else
            {
                button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
                button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
                button2.Enabled = true;
                button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
                button3.Enabled = true;
                button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
                button4.Enabled = true;
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
                flowLayoutPanel1.Visible = false;
                pictureBox1.Enabled = true;
            }
            t++;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            but.Play();
            if ((t % 2) == 1)
            {
                button1.Location = new Point(button1.Location.X - 250, button1.Location.Y);
                button2.Location = new Point(button2.Location.X - 250, button2.Location.Y);
                button3.Location = new Point(button3.Location.X - 250, button3.Location.Y);
                button4.Location = new Point(button4.Location.X - 250, button4.Location.Y);
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X - 150, flowLayoutPanel1.Location.Y);
                flowLayoutPanel1.Visible = true;
                button1.Enabled = false;button3.Enabled = false;button4.Enabled = false; pictureBox1.Enabled = false;

            }
            else
            {
                button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
                button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
                button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
                button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
                flowLayoutPanel1.Visible = false;
                button1.Enabled = true; button3.Enabled = true; button4.Enabled = true; pictureBox1.Enabled = true;
            }
            t++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            but.Play();
            if ((t % 2) == 1)
            {
                button1.Location = new Point(button1.Location.X - 250, button1.Location.Y);
                button2.Location = new Point(button2.Location.X - 250, button2.Location.Y);
                button3.Location = new Point(button3.Location.X - 250, button3.Location.Y);
                button4.Location = new Point(button4.Location.X - 250, button4.Location.Y);
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X - 150, flowLayoutPanel1.Location.Y);
                flowLayoutPanel1.Visible = true;
                button1.Enabled = false; button2.Enabled = false; button4.Enabled = false; pictureBox1.Enabled = false;

            }
            else
            {
                button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
                button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
                button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
                button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
                flowLayoutPanel1.Visible = false;
                button1.Enabled = true; button2.Enabled = true; button4.Enabled = true; pictureBox1.Enabled = true;
            }
            t++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            but.Play();
            if ((t % 2) == 1)
            {
                button1.Location = new Point(button1.Location.X - 250, button1.Location.Y);
                button2.Location = new Point(button2.Location.X - 250, button2.Location.Y);
                button3.Location = new Point(button3.Location.X - 250, button3.Location.Y);
                button4.Location = new Point(button4.Location.X - 250, button4.Location.Y);
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X - 150, flowLayoutPanel1.Location.Y);
                flowLayoutPanel1.Visible = true;
                button1.Enabled = false; button3.Enabled = false; button2.Enabled = false; pictureBox1.Enabled = false;

            }
            else
            {
                button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
                button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
                button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
                button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
                flowLayoutPanel1.Visible = false;
                button1.Enabled = true; button3.Enabled = true; button2.Enabled = true; pictureBox1.Enabled = true;
            }
            t++;

        }
        SoundPlayer player = new SoundPlayer("C:\\Users\\Dmitrii\\documents\\visual studio 2015\\Projects\\GameTest\\GameTest\\Resources\\1.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();
            player.PlayLooping();
           
        }
       
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                player.Stop();
            }
            else
            {
                player.Play();
            }
        }
        
    }
}
