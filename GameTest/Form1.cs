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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using GameTest.Properties;
using GameTest.DB_model;
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
            Close();
        }
        int i = 1;
        int l = 1;
         private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";
            
                if ((i % 2) == 1)
                {
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;

                    tableLayoutPanel1.Visible = true;

                }
                else
                {

                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;

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
                Size = new Size(800,600);
            }
            if (comboBox1.Text == "1280x1024")
            {
                Size = new Size(1280, 1024);
                if (checkBox1.Checked == false)
                {
                    button1.Location = new Point(400, 200);
                    button2.Location = new Point(400, 285);
                    button3.Location = new Point(400, 370);
                    button4.Location = new Point(400, 455);
                    tableLayoutPanel1.Location = new Point(250, 200);
                    flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X, 180);
                    tableLayoutPanel9.Location = new Point(350, 200);
                }
                /* else
                 {
                     button1.Location = new Point(300, 100);
                     button2.Location = new Point(300, 185);
                     button3.Location = new Point(300, 270);
                     button4.Location = new Point(300, 355);
                     tableLayoutPanel1.Location = new Point(100, 50);
                     flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X, 70);
                 }*/
             }
             if (comboBox1.Text == "1024x768")
             {
                 Size = new Size(1024, 768);
                 if (checkBox1.Checked == false)
                 {
                     button1.Location = new Point(300, button1.Location.Y);
                     button2.Location = new Point(300, button2.Location.Y);
                     button3.Location = new Point(300, button3.Location.Y);
                     button4.Location = new Point(300, button4.Location.Y);
                 }
                 /*else
                 {
                     button1.Location = new Point(300, button1.Location.Y);
                     button2.Location = new Point(300, button2.Location.Y);
                     button3.Location = new Point(300, button3.Location.Y);
                     button4.Location = new Point(300, button4.Location.Y);
                 }*/
            }
            if (comboBox1.Text == "1280x720")
            {
                Size = new Size(1280, 720);
                if (checkBox1.Checked == false)
                {
                    button1.Location = new Point(400, 100);
                    button2.Location = new Point(400, 185);
                    button3.Location = new Point(400, 270);
                    button4.Location = new Point(400, 355);
                    tableLayoutPanel1.Location = new Point(250, 100);
                    flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X, 70);
                }
                /* else
                {
                    button1.Location = new Point(300, 100);
                    button2.Location = new Point(300, 185);
                    button3.Location = new Point(300, 270);
                    button4.Location = new Point(300, 355);
                    tableLayoutPanel1.Location = new Point(100, 50);
                    flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X, 70);
                }*/
            }
            if (comboBox1.Text == "1920x1080")
            {
                Size = new Size(1920, 1080);
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                button1.Location = new Point(400, 200);
                button2.Location = new Point(400, 285);
                button3.Location = new Point(400, 370);
                button4.Location = new Point(400, 455);
                tableLayoutPanel8.Location = new Point(225,200);
                tableLayoutPanel1.Location = new Point(250, 200);
                flowLayoutPanel1.Location = new Point(900, 180);
                comboBox1.Enabled = false;
                tableLayoutPanel8.Size = new Size(900, 500);
                label9.Location = new Point(520,350);
                label14.Location = new Point(430, 150);
                label15.Location = new Point(450, 280);
                tableLayoutPanel9.Location = new Point(350,200);
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                button1.Location = new Point(300, 100);
                button2.Location = new Point(300, 185);
                button3.Location = new Point(300, 270);
                button4.Location = new Point(300, 355);
                tableLayoutPanel8.Location = new Point(25, 25);
                tableLayoutPanel1.Location = new Point(100, 50);
                flowLayoutPanel1.Location = new Point(550, 70);
                comboBox1.Enabled = true;
                tableLayoutPanel8.Size = new Size(740, 390);
                label9.Location = new Point(300,200);
                label14.Location = new Point(190, 30);
                label15.Location = new Point(220, 130);
                tableLayoutPanel9.Location = new Point(70,70);

            }
        }
        int t = 1;
        int b1 = 1;
        int b2 = 1;
        int b3 = 1;
        int b4 = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            b1++;
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";
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
            b2++;
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";
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
            b3++;
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";
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
            b4++;
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";
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
        SqlConnection sqlCon;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [GTK1] WHERE id_kat=1", sqlCon);
            try
            {
                sqlRe = command.ExecuteReader();
                sqlRe.Read();
                label1.Text = Convert.ToString(sqlRe["nazvanie"]) + "\n" + "Cоздание:" + Convert.ToString(sqlRe["datas"]) + "\n" + "Изменение:" + Convert.ToString(sqlRe["datar"]); 
            }
            finally
            {

            }
            
            
            timer1.Stop();
            timer2.Stop();
            timer3.Start();
            axWindowsMediaPlayer2.settings.volume = 10;
            pictureBox3.Enabled = false;
            Random m1 = new Random();
            int m = m1.Next(1, 4);

            switch (m)
            {
                case 1:
                    axWindowsMediaPlayer1.URL = "1\\1.wav";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                case 2:
                    axWindowsMediaPlayer1.URL = "1\\2.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                case 3:
                    axWindowsMediaPlayer1.URL = "1\\3.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                default:
                    axWindowsMediaPlayer1.URL = "1\\1.wav";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
            }
            label9.Location = new Point(300, 200);
            tableLayoutPanel8.Location = new Point(30, 50);
            flowLayoutPanel1.Location = new Point(550, 50);
            tableLayoutPanel1.Location = new Point(100, 50);
            label14.Location = new Point(190, 50);
            label15.Location = new Point(220, 130);
            tableLayoutPanel9.Location = new Point(70, 70);
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value - 3;
            
            Size = new Size(800, 600);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                axWindowsMediaPlayer1.settings.volume = 0;
            }
            else
            {
                axWindowsMediaPlayer2.URL = "1\\kn.mp3";
                axWindowsMediaPlayer1.settings.volume = trackBar1.Value;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {

                axWindowsMediaPlayer2.settings.volume = 0;
            }
            else
            {
                axWindowsMediaPlayer2.URL = "1\\kn.mp3";
                axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
            button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
            button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
            button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";
            if (b1 % 2 == 0)
            {
                sqlCon = new SqlConnection(Settings.Default.ConectDb);
                sqlCon.Open();
                SqlDataReader sqlRe1 = null;
                SqlCommand command1 = new SqlCommand("SELECT * FROM [GTK1]", sqlCon);
                    try
                    {
                        sqlRe1 = command1.ExecuteReader();
                        sqlRe1.Read();
                    label15.Text = label15.Text + Convert.ToString(sqlRe1["name_kat"]) + "\n";
                    label8.Text = Convert.ToString(sqlRe1["name_kat"]);
                    for (int x = 1; x < 5; x++)
                    {
                        command1 = new SqlCommand("SELECT * FROM [GTK1] WHERE id_kat=" + x, sqlCon);
                        sqlRe1.Read();
                        label15.Text = label15.Text + Convert.ToString(sqlRe1["name_kat"]) + "\n";
                        switch (x) {
                            case 1:
                                label10.Text = Convert.ToString(sqlRe1["name_kat"]);
                                break;
                            case 2:
                                label11.Text = Convert.ToString(sqlRe1["name_kat"]);
                                break;
                            case 3:
                                label12.Text = Convert.ToString(sqlRe1["name_kat"]);
                                break;
                            case 4:
                                label13.Text = Convert.ToString(sqlRe1["name_kat"]);
                                break;
                                 } 
                    }
                    }
                    finally
                    {

                    }
              
                flowLayoutPanel1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                label9.Visible = true;
                timer1.Start();
                b1++;

            }
            if (b2 % 2 == 0)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
            button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
            button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
            button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";

            flowLayoutPanel1.Visible = false;
            t=1;
            b1 = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
            button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
            button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
            button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";

            flowLayoutPanel1.Visible = false;
            t = 1;
            b1 = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
            button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
            button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
            button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";

            flowLayoutPanel1.Visible = false;
            t = 1;
            b1 = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
            button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
            button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
            button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";

            flowLayoutPanel1.Visible = false;
            t = 1;
            b1 = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Location = new Point(button1.Location.X + 250, button1.Location.Y);
            button2.Location = new Point(button2.Location.X + 250, button2.Location.Y);
            button3.Location = new Point(button3.Location.X + 250, button3.Location.Y);
            button4.Location = new Point(button4.Location.X + 250, button4.Location.Y);
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 150, flowLayoutPanel1.Location.Y);
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";

            flowLayoutPanel1.Visible = false;
            t = 1;
            b1 = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Visible = false;
            label14.Visible = true;
            label15.Visible = true;
            timer2.Start();
            timer1.Stop();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label14.Visible = false;
            label15.Visible = false;
            tableLayoutPanel8.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Enabled = true;
            timer2.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if ((l % 2) == 1)
            {
                tableLayoutPanel8.Visible = false;
                tableLayoutPanel1.Visible = true;
                pictureBox4.Enabled = false;
            }
            else
            {
                tableLayoutPanel8.Visible = true;
                tableLayoutPanel1.Visible = false;
                pictureBox4.Enabled = true;
            }
            l++;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            tableLayoutPanel8.Visible = false;
            
            pictureBox1.Enabled = true;
            pictureBox3.Enabled = false;
            t++;
            pictureBox4.Visible = false;
            label15.Text = "";
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random m1 = new Random();
            int m = m1.Next(1, 4);

            switch (m)
            {
                case 1:
                    axWindowsMediaPlayer1.URL = "1\\1.wav";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                case 2:
                    axWindowsMediaPlayer1.URL = "1\\2.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                case 3:
                    axWindowsMediaPlayer1.URL = "1\\3.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                default:
                    axWindowsMediaPlayer1.URL = "1\\1.wav";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
            }
            timer3.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            }
            if (checkBox3.Checked == true)
            {
                axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            }
            
        }
        int vop = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            vop = 1;
            sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [GTV1] WHERE id=" + vop, sqlCon);
                sqlRe = command.ExecuteReader();
                sqlRe.Read();
                label16.Text = Convert.ToString(sqlRe["tekst"]);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            timer4.Start();
            button11.Visible = false;
            progressBar1.Visible = true;
            

        }
        
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 150)
                    progressBar1.Value += 1;
                else
                {
                
                   /* sqlCon = new SqlConnection(Settings.Default.ConectDb);
                    sqlCon.Open();
                    SqlDataReader sqlRe = null;
                    SqlCommand command = new SqlCommand("SELECT * FROM [GTV1] WHERE id=" + vop, sqlCon);
                        sqlRe = command.ExecuteReader();
                        sqlRe.Read();
                        label16.Text = Convert.ToString(sqlRe["otvet"]);*/
                label16.Text = Context.Otv(vop);




                axWindowsMediaPlayer2.URL = "1\\kn.mp3";
                timer4.Stop();
                timer5.Start();
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                }
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            tableLayoutPanel8.Visible = true;
            tableLayoutPanel9.Visible = false;
            timer5.Stop();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            vop = 2;
            /*sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [GTV1] WHERE id=" + vop, sqlCon);
                sqlRe = command.ExecuteReader();
                sqlRe.Read();*/
            label16.Text = Context.Vops(vop);


            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            timer4.Start();
            button12.Visible = false;
            progressBar1.Visible = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            vop = 3;
            string connectionStr = Settings.Default.ConectDb;
            sqlCon = new SqlConnection(connectionStr);
            sqlCon.Open();
            SqlDataReader sqlRe = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [GTV1] WHERE id=" + vop, sqlCon);
                sqlRe = command.ExecuteReader();
                sqlRe.Read();
                label16.Text = Convert.ToString(sqlRe["tekst"]);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            timer4.Start();
            button13.Visible = false;
            progressBar1.Visible = true;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            vop = 4;
            sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [GTV1] WHERE id=" + vop, sqlCon);
                sqlRe = command.ExecuteReader();
                sqlRe.Read();
                label16.Text = Convert.ToString(sqlRe["tekst"]);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            timer4.Start();
            button14.Visible = false;
            progressBar1.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            vop = 5;
            sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [GTV1] WHERE id=" + vop, sqlCon);
                sqlRe = command.ExecuteReader();
                sqlRe.Read();
                label16.Text = Convert.ToString(sqlRe["tekst"]);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            timer4.Start();
            button15.Visible = false;
            progressBar1.Visible = true;
        }


        // Max.porn


       static public bool Tru = true;
        private void tableLayoutPanel9_Click(object sender, EventArgs e)
        {
            int resultTime = progressBar1.Value;
            if (Tru)
            {
                timer4.Stop();
                Tru = false;

            }
            else
            {
                timer4.Start();
                Tru = true;
            }
            
        }
        

        ////////////////////////////////////////////////



    }
}
