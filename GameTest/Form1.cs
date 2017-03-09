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
using System.Threading;

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
        public static int tn = 0;
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
                tableLayoutPanel10.Visible = false;
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1024x768")
            {
                Size = new Size(1024, 768);
                
                    button1.Location = new Point(300, 100);
                    button2.Location = new Point(300, 185);
                    button3.Location = new Point(300, 270);
                    button4.Location = new Point(300, 355);
                    label9.Location = new Point(400, 200);
                    tableLayoutPanel8.Location = new Point(150, 80);
                    flowLayoutPanel1.Location = new Point(750, 70);
                    tableLayoutPanel1.Location = new Point(120, 100);
                    //label14.Location = new Point(290, 50);
                    //label15.Location = new Point(320, 130);
                    tableLayoutPanel9.Location = new Point(150, 80);
                    progressBar1.Location = new Point(325, progressBar1.Location.Y);
                    groupBox1.Location = new Point(150, 490);
                    groupBox2.Location = new Point(375, 490);
                    groupBox3.Location = new Point(600, 490);


            }
            if (comboBox1.Text == "1280x968")
            {
                Size = new Size(1280, 968);

                button1.Location = new Point(400, 200);
                button2.Location = new Point(400, 285);
                button3.Location = new Point(400, 370);
                button4.Location = new Point(400, 455);
                tableLayoutPanel8.Location = new Point(225, 100);
                tableLayoutPanel1.Location = new Point(250, 100);
                flowLayoutPanel1.Location = new Point(900, 180);
                tableLayoutPanel8.Size = new Size(900, 500);
                tableLayoutPanel9.Size = new Size(900, 500);
                label9.Location = new Point(520, 350);
                //label14.Location = new Point(430, 150);
                //label15.Location = new Point(450, 280);
                tableLayoutPanel9.Location = new Point(225, 100);
                progressBar1.Location = new Point(450, progressBar1.Location.Y);
                groupBox1.Location = new Point(220, 690);
                groupBox2.Location = new Point(470, 690);
                groupBox3.Location = new Point(720, 690);
            }
           
            
            if (comboBox1.Text == "1920x1000")
            {
                Size = new Size(1920, 1000);

                button1.Location = new Point(400, 200);
                button2.Location = new Point(400, 285);
                button3.Location = new Point(400, 370);
                button4.Location = new Point(400, 455);
                tableLayoutPanel8.Location = new Point(225, 100);
                tableLayoutPanel1.Location = new Point(250, 100);
                flowLayoutPanel1.Location = new Point(900, 180);
                tableLayoutPanel8.Size = new Size(900, 500);
                tableLayoutPanel9.Size = new Size(900, 500);
                label9.Location = new Point(520, 350);
                //label14.Location = new Point(430, 150);
                //label15.Location = new Point(450, 280);
                tableLayoutPanel9.Location = new Point(225, 100);
                progressBar1.Location = new Point(450, progressBar1.Location.Y);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";
            if (checkBox1.Checked == true)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                button1.Location = new Point(400, 200);
                button2.Location = new Point(400, 285);
                button3.Location = new Point(400, 370);
                button4.Location = new Point(400, 455);
                tableLayoutPanel8.Location = new Point(225, 100);
                tableLayoutPanel1.Location = new Point(250, 100);
                flowLayoutPanel1.Location = new Point(900, 180);
                comboBox1.Enabled = false;
                tableLayoutPanel8.Size = new Size(900, 500);
                tableLayoutPanel9.Size = new Size(900, 500);
                label9.Location = new Point(520,350);
                //label14.Location = new Point(430, 150);
                //label15.Location = new Point(450, 280);
                tableLayoutPanel9.Location = new Point(225, 100);
                progressBar1.Location = new Point(450, progressBar1.Location.Y);
                groupBox1.Location = new Point(200, 700);
                groupBox2.Location = new Point(500, 700);
                groupBox3.Location = new Point(800, 700);
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                button1.Location = new Point(300, 100);
                button2.Location = new Point(300, 185);
                button3.Location = new Point(300, 270);
                button4.Location = new Point(300, 355);
                label9.Location = new Point(400, 200);
                comboBox1.Enabled = true;
                tableLayoutPanel8.Location = new Point(150, 80);
                flowLayoutPanel1.Location = new Point(750, 70);
                tableLayoutPanel1.Location = new Point(120, 100);
                //label14.Location = new Point(290, 50);
                //label15.Location = new Point(320, 130);
                tableLayoutPanel9.Location = new Point(150, 80);
                progressBar1.Location = new Point(325, progressBar1.Location.Y);
                groupBox1.Location = new Point(150, 490);
                groupBox2.Location = new Point(375, 490);
                groupBox3.Location = new Point(600, 490);
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
                button5.Text = "Изменить";
                button6.Text = "Изменить";
                button7.Text = "Изменить";
                button8.Text = "Изменить";
                button9.Text = "Изменить";
                button10.Text = "Изменить";

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
                button5.Text = "Начать";
                button6.Text = "Начать";
                button7.Text = "Начать";
                button8.Text = "Начать";
                button9.Text = "Начать";
                button10.Text = "Начать";
            }
            t++;

        }
        SqlConnection sqlCon;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe1 = null;
            SqlCommand command1 = new SqlCommand("SELECT * FROM [GTK1] WHERE id_kat=1", sqlCon);
                sqlRe1 = command1.ExecuteReader();
                sqlRe1.Read();
                label1.Text = Convert.ToString(sqlRe1["nazvanie"]) + "\n" + "Cоздание:" + Convert.ToString(sqlRe1["datas"]) + "\n" + "Изменение:" + Convert.ToString(sqlRe1["datar"]);

            sqlCon = new SqlConnection(Settings.Default.ConectDb);
            sqlCon.Open();
            SqlDataReader sqlRe2 = null;
            SqlCommand command2 = new SqlCommand("SELECT * FROM [GTK2] WHERE id_kat=1", sqlCon);
            sqlRe2 = command2.ExecuteReader();
            sqlRe2.Read();
            label2.Text = Convert.ToString(sqlRe2["nazvanie"]) + "\n" + "Cоздание:" + Convert.ToString(sqlRe2["datas"]) + "\n" + "Изменение:" + Convert.ToString(sqlRe2["datar"]);

            timer1.Stop();
            timer2.Stop();
            timer3.Start();
            axWindowsMediaPlayer2.settings.volume = 10;
            pictureBox3.Enabled = false;
            Random m1 = new Random();
            int m = m1.Next(1, 5);
            switch (m)
            {
                case 1:
                    axWindowsMediaPlayer1.URL = "1\\1.mp3";
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
                case 4:
                    axWindowsMediaPlayer1.URL = "1\\4.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                default:
                    axWindowsMediaPlayer1.URL = "1\\2.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
            }
            label9.Location = new Point(400, 200);
            tableLayoutPanel8.Location = new Point(150, 80);
            flowLayoutPanel1.Location = new Point(750, 70);
            tableLayoutPanel1.Location = new Point(120, 100);
            //label14.Location = new Point(290, 50);
            label15.Location = new Point(130, 130);
            tableLayoutPanel9.Location = new Point(150, 80);
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value - 3;
            button1.Location = new Point(300, 100);
            button2.Location = new Point(300, 185);
            button3.Location = new Point(300, 270);
            button4.Location = new Point(300, 355);
            tableLayoutPanel10.Location = new Point(150, 100);
            groupBox1.Location = new Point(150, 490);
            groupBox2.Location = new Point(375, 490);
            groupBox3.Location = new Point(600, 490);
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
            tn = 1;
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
                SqlCommand command1 = new SqlCommand("SELECT * FROM [GTK"+ tn +"]", sqlCon);
                        sqlRe1 = command1.ExecuteReader();
                        sqlRe1.Read();
                    label15.Text = "Темы раунда:\n" + Convert.ToString(sqlRe1["name_kat"]) + "\n";
                    label8.Text = Convert.ToString(sqlRe1["name_kat"]);
                for (int x = 1; x < 5; x++)
                {
                    command1 = new SqlCommand("SELECT * FROM [GTK" + tn + "] WHERE id_kat=" + x, sqlCon);
                    sqlRe1.Read();
                    label15.Text = label15.Text + Convert.ToString(sqlRe1["name_kat"]) + "\n";
                    switch (x)
                    {
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
                flowLayoutPanel1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                button39.Visible = true;
                //timer1.Start();
                b1++;

            }
            if (b2 % 2 == 0)
            {
                sqlCon = new SqlConnection(Settings.Default.ConectDb);
                sqlCon.Open();
                SqlDataReader sqlRe1 = null;
                SqlCommand command1 = new SqlCommand("SELECT * FROM [GTK" + tn + "]", sqlCon);
                sqlRe1 = command1.ExecuteReader();
                sqlRe1.Read();
                label15.Text = "Темы раунда:\n" + Convert.ToString(sqlRe1["name_kat"]) + "\n";
                label8.Text = Convert.ToString(sqlRe1["name_kat"]);
                for (int x = 1; x < 5; x++)
                {
                    command1 = new SqlCommand("SELECT * FROM [GTK" + tn + "] WHERE id_kat=" + x, sqlCon);
                    sqlRe1.Read();
                    label15.Text = label15.Text + Convert.ToString(sqlRe1["name_kat"]) + "\n";
                    switch (x)
                    {
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
                flowLayoutPanel1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                label9.Visible = true;
                timer1.Start();
                b2++;
            }
            if (b4 % 2 == 0)
            {
                tableLayoutPanel10.Visible = true;
                pictureBox1.Enabled = true;
                flowLayoutPanel1.Visible = false;
                b4++;
                t = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tn = 2;
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
                SqlCommand command1 = new SqlCommand("SELECT * FROM [GTK" + tn + "]", sqlCon);
                sqlRe1 = command1.ExecuteReader();
                sqlRe1.Read();
                label15.Text = "Темы раунда:\n" + Convert.ToString(sqlRe1["name_kat"]) + "\n";
                label8.Text = Convert.ToString(sqlRe1["name_kat"]);
                for (int x = 1; x < 5; x++)
                {
                    command1 = new SqlCommand("SELECT * FROM [GTK" + tn + "] WHERE id_kat=" + x, sqlCon);
                    sqlRe1.Read();
                    label15.Text = label15.Text + Convert.ToString(sqlRe1["name_kat"]) + "\n";
                    switch (x)
                    {
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
                flowLayoutPanel1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                label9.Visible = true;
                timer1.Start();
                b1++;

            }
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
            //label14.Visible = true;
            label15.Visible = true;
            timer2.Start();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //label14.Visible = false;
            label15.Visible = false;
            tableLayoutPanel8.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Enabled = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
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
            tableLayoutPanel9.Visible = false;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            timer4.Stop();
            timer5.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random m1 = new Random();
            int m = m1.Next(1, 5);
            switch (m)
            {
                case 1:
                    axWindowsMediaPlayer1.URL = "1\\1.mp3";
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
                case 4:
                    axWindowsMediaPlayer1.URL = "1\\4.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                default:
                    axWindowsMediaPlayer1.URL = "1\\1.mp3";
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
        public int och = 0;
        public int tyr = 0;
        public int raun = 1;
        private void button11_Click(object sender, EventArgs e)
        {
            if (raun == 1)
            {vop = 1; och = 1; }
            if (raun == 2)
            {vop = 26; och = 1; }
            if (raun == 3)
            {vop = 51; och = 1; }
            progressBar1.Value = 0;
            label16.Text = Helper.Vops(vop,tn);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            button11.Visible = false;
            progressBar1.Visible = true;
            tyr++;
        }
        
        private void timer4_Tick(object sender, EventArgs e)
        {
            if(tyr == 25)
            {
                raun++;
            }
            if (progressBar1.Value < progressBar1.Maximum)
                    progressBar1.Value += 1;
                else
                {
                label16.Text = Helper.Otv(vop,tn);
                axWindowsMediaPlayer2.URL = "1\\kn.mp3";
                timer4.Stop();
                timer5.Start();
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (tyr < 25)
            {
                tableLayoutPanel8.Visible = true;
                tableLayoutPanel9.Visible = false;
                timer5.Stop();
            }
            if (raun == 2)
            {
                label9.Visible = true;
                label9.Text = "Раунд 2";
                timer1.Start();
            }
            if (raun == 3)
            {
                label9.Visible = true;
                label9.Text = "Раунд 3";
                timer1.Start();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (raun == 1)
            { vop = 2; och = 2; }
            if (raun == 2)
            { vop = 27; och = 2; }
            if (raun == 3)
            { vop = 52; och = 2; }
            progressBar1.Value = 0;
            label16.Text = Helper.Vops(vop,tn);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            button12.Visible = false;
            progressBar1.Visible = true;
            och = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (raun == 1)
            { vop = 3; och = 3; }
            if (raun == 2)
            { vop = 28; och = 3; }
            if (raun == 3)
            { vop = 53; och = 3; }
            progressBar1.Value = 0;
            label16.Text = Helper.Vops(vop,tn);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            button13.Visible = false;
            progressBar1.Visible = true;
            och = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (raun == 1)
            { vop = 4; och = 4; }
            if (raun == 2)
            { vop = 29; och = 4; }
            if (raun == 3)
            { vop = 54; och = 4; }
            progressBar1.Value = 0;
            label16.Text = Helper.Vops(vop,tn);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            button14.Visible = false;
            progressBar1.Visible = true;
            och = 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (raun == 1)
            { vop = 5; och = 5; }
            if (raun == 2)
            { vop = 30; och = 5; }
            if (raun == 3)
            { vop = 55; och = 5; }
            progressBar1.Value = 0;
            label16.Text = Helper.Vops(vop,tn);
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = true;
            button15.Visible = false;
            progressBar1.Visible = true;
            och = 5;
        }
        
        
       static public bool Tru = false;
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

        private void label16_Click(object sender, EventArgs e)
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
        private void randAudio_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "1\\kn.mp3";
            Random m1 = new Random();
            int m = m1.Next(1, 5);
            switch (m)
            {
                case 1:
                    axWindowsMediaPlayer1.URL = "1\\1.mp3";
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
                case 4:
                    axWindowsMediaPlayer1.URL = "1\\4.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
                default:
                    axWindowsMediaPlayer1.URL = "1\\1.mp3";
                    axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                axWindowsMediaPlayer2.URL = "1\\kn.mp3";
                if(Tru)
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
        }
        int itemup1 = 0;
        int itemup2 = 0;
        int itemup3 = 0;
        private void button36_Click(object sender, EventArgs e)
        {
            if (itemup1 < 5)
            { 
                comboBox2.Items.Add(comboBox2.Text);
                itemup1++;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (itemup2 < 5)
            {
                comboBox3.Items.Add(comboBox2.Text);
                itemup2++;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (itemup3 < 5)
            {
                comboBox4.Items.Add(comboBox2.Text);
                itemup3++;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            sqlCon = new SqlConnection(Settings.Default.ConectDb);
            SqlCommand command = new SqlCommand();
         
            for (int x = 0; x < 5; x++)
            {
                sqlCon.Open();
                command = new SqlCommand("UPDATE GTK" + tn + " SET name_kat = " + comboBox2.Items[x] + " WHERE id_kat = " + x + 1,sqlCon);
                
                command.ExecuteNonQuery();
                sqlCon.Close();
            }
           
            
            sqlCon.Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            label20.Text = textBox2.Text;
            label21.Text = textBox3.Text;
            label22.Text = textBox4.Text;
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            button39.Visible = false;
            label9.Visible = true;
            timer1.Start();
        }
        public int ochki1 = 0;
        public int ochki2 = 0;
        public int ochki3 = 0;
        
        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            if (progressBar1.Value > 0 && e.Button == MouseButtons.Left)
                {
                    ochki1 = ochki1 + och;
                    textBox2.Text = Convert.ToString(ochki1);
                    progressBar1.Value = progressBar1.Maximum;
                    timer4.Start();
                }
            if (progressBar1.Value > 0 && e.Button == MouseButtons.Right)
            {
                ochki1 = ochki1 - och;
                textBox2.Text = Convert.ToString(ochki1);
                timer4.Start();
                pictureBox7.Enabled = false;
            }
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            if (progressBar1.Value > 0 && e.Button == MouseButtons.Left)
            {
                ochki2 = ochki2 + och;
                textBox3.Text = Convert.ToString(ochki2);
                progressBar1.Value = progressBar1.Maximum;
                timer4.Start();
            }
            if (progressBar1.Value > 0 && e.Button == MouseButtons.Right)
            {
                ochki2 = ochki2 - och;
                textBox3.Text = Convert.ToString(ochki2);
                timer4.Start();
                pictureBox8.Enabled = false;
            }
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            if (progressBar1.Value > 0 && e.Button == MouseButtons.Left)
            {
                ochki3 = ochki3 + och;
                textBox4.Text = Convert.ToString(ochki3);
                progressBar1.Value = progressBar1.Maximum;
                timer4.Start();
            }
            if (progressBar1.Value > 0 && e.Button == MouseButtons.Right)
            {
                ochki3 = ochki3 - och;
                textBox4.Text = Convert.ToString(ochki3);
                timer4.Start();
                pictureBox9.Enabled = false;
            }
        }

    }
}
