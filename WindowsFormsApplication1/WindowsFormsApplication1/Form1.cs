using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{
    public partial class BeatRat : Form
    {
        [DllImport("user32.dll", EntryPoint = "LoadCursorFromFile")]
        public static extern IntPtr LoadCursorFromFile(string lpFileName);
        public Cursor cur1, cur2;
        int score, times;
//        string username;
        string NoneP = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "none.png");
        string Killed = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "killed.png");
        
        bool[] filled = new bool[10];

        public BeatRat()
        {
            InitializeComponent();
            Timer1.Enabled = false;
            times = 0;
            score = 0;
            Picture1.Image = System.Drawing.Image.FromFile(NoneP);
            Picture3.Image = System.Drawing.Image.FromFile(NoneP);
            Picture5.Image = System.Drawing.Image.FromFile(NoneP);
            Picture2.Image = System.Drawing.Image.FromFile(NoneP);
            Picture4.Image = System.Drawing.Image.FromFile(NoneP);
            Picture6.Image = System.Drawing.Image.FromFile(NoneP);
            Picture7.Image = System.Drawing.Image.FromFile(NoneP);
            Picture8.Image = System.Drawing.Image.FromFile(NoneP);
            Picture9.Image = System.Drawing.Image.FromFile(NoneP);

            //Timer1.Enabled = true;
        }

        private void BeatRat_Load(object sender, EventArgs e)
        {
            Form2 ff = new Form2(this);
            ff.textBox3.Visible = false;
            ff.textBox1.Visible = true;
            ff.textBox2.Visible = true;

            ff.Show();
            //username = ff.textBox2.Text;
            //textBox1.Text = username + "，欢迎您";
        }

        //Image NoneImage = new Image(NoneP);

        private void Picture1_MouseDown(object sender, MouseEventArgs e)
        {
            Picture1.Cursor = cur2;
            if (filled[1])
            {
                score++;
                Picture1.Image = System.Drawing.Image.FromFile(Killed);
                filled[1] = false;
            }
            else
            { }
        }


        private void Picture3_MouseDown(object sender, MouseEventArgs e)
        {
            Picture3.Cursor = cur2;
            if (filled[3])
            {
                score++;
                Picture3.Image = System.Drawing.Image.FromFile(Killed);
                filled[3] = false;
            }
            else
            { }
        }

        private void Picture5_MouseDown(object sender, MouseEventArgs e)
        {
            Picture5.Cursor = cur2;
            if (filled[5])
            {
                score++;
                Picture5.Image = System.Drawing.Image.FromFile(Killed);
                filled[5] = false;
            }
            else
            { }
        }

        private void Picture2_MouseDown(object sender, MouseEventArgs e)
        {
            Picture2.Cursor = cur2;
            if (filled[2])
            {
                score++;
                Picture2.Image = System.Drawing.Image.FromFile(Killed);
                filled[2] = false;
            }
            else
            { }
        }

        private void Picture4_MouseDown(object sender, MouseEventArgs e)
        {
            Picture4.Cursor = cur2;
            if (filled[4])
            {
                score++;
                Picture4.Image = System.Drawing.Image.FromFile(Killed);
                filled[4] = false;
            }
            else
            { }
        }

        private void Picture6_MouseDown(object sender, MouseEventArgs e)
        {
            Picture6.Cursor = cur2;
            if (filled[6])
            {
                score++;
                Picture6.Image = System.Drawing.Image.FromFile(Killed);
                filled[6] = false;
            }
            else
            { }
        }

        private void Picture7_MouseDown(object sender, MouseEventArgs e)
        {
            Picture7.Cursor = cur2;
            if (filled[7])
            {
                score++;
                Picture7.Image = System.Drawing.Image.FromFile(Killed);
                filled[7] = false;
            }
            else
            { }
        }

        private void Picture8_MouseDown(object sender, MouseEventArgs e)
        {
            Picture8.Cursor = cur2;
            if (filled[8])
            {
                score++;
                Picture8.Image = System.Drawing.Image.FromFile(Killed);
                filled[8] = false;
            }
            else
            { }
        }

        private void Picture9_MouseDown(object sender, MouseEventArgs e)
        {
            Picture9.Cursor = cur2;
            if (filled[9])
            {
                score++;
                Picture9.Image = System.Drawing.Image.FromFile(Killed);
                filled[9] = false;
            }
            else
            { }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            double x = score * 2  / (times + 1);
            double y = -133.5 * Math.Log(x) + 100.0;

            if (y > 500) y = 500;
            else if (y < 20) y = 100;
            Timer1.Interval = (int)y;
            if (times < 300)
            {
                //srand((int)time(0));

                times++;

                /*
                string  strCodeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                int n = strCodeBase.LastIndexOf('/');        
                string FolderPath = strCodeBase.Substring(8, n - 8);*/

                string FileP = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mouse.png");

                Random ra = new Random();

                Picture1.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture1.Image = System.Drawing.Image.FromFile(FileP);
                    filled[1] = true;
                }

                Picture2.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture2.Image = System.Drawing.Image.FromFile(FileP);
                    filled[2] = true;
                }

                Picture3.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture3.Image = System.Drawing.Image.FromFile(FileP);
                    filled[3] = true;
                }

                Picture4.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture4.Image = System.Drawing.Image.FromFile(FileP);
                    filled[4] = true;
                }

                Picture5.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture5.Image = System.Drawing.Image.FromFile(FileP);
                    filled[5] = true;
                }

                Picture6.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture6.Image = System.Drawing.Image.FromFile(FileP);
                    filled[6] = true;
                }

                Picture7.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture7.Image = System.Drawing.Image.FromFile(FileP);
                    filled[7] = true;
                }

                Picture8.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture8.Image = System.Drawing.Image.FromFile(FileP);
                    filled[8] = true;
                }

                Picture9.Image = System.Drawing.Image.FromFile(NoneP);
                if (ra.Next(100) < 20)
                {
                    Picture9.Image = System.Drawing.Image.FromFile(FileP);
                    filled[9] = true;
                }
                Text1.Text = "您打了" + score.ToString() + "分";
                Text2.Text = "已经过了" + times.ToString() + "幅图";
            }
            else
            {
                Picture1.Image = System.Drawing.Image.FromFile(NoneP);
                Picture3.Image = System.Drawing.Image.FromFile(NoneP);
                Picture5.Image = System.Drawing.Image.FromFile(NoneP);
                Picture2.Image = System.Drawing.Image.FromFile(NoneP);
                Picture4.Image = System.Drawing.Image.FromFile(NoneP);
                Picture6.Image = System.Drawing.Image.FromFile(NoneP);
                Picture7.Image = System.Drawing.Image.FromFile(NoneP);
                Picture8.Image = System.Drawing.Image.FromFile(NoneP);
                Picture9.Image = System.Drawing.Image.FromFile(NoneP);

                for (int i = 1; i < 10; i++)
                    filled[i] = false;

                Text2.Text = "游戏结束";
                Timer1.Enabled = false;
                /*
                */

                MessageBox.Show(textBox1.Text.Substring(0, textBox1.Text.Length - 4) + "：\n游戏结束了，" + "您共打了" + score.ToString() + "分" + "\n恭喜您");
                Form2 ff = new Form2(this);
                ff.textBox3.Visible = true;
                ff.textBox1.Visible = false;
                ff.textBox2.Visible = false;
                ff.textBox3.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 4) + "：\n\t\n\t游戏结束了，" + "您共打了" + score.ToString() + "分" + "\n恭喜您";

                ff.Show();

                string FILE_NAME = "g_dds.dat";
                {
                    StreamWriter sr;
                    if (File.Exists(FILE_NAME)) //如果文件存在,则创建File.AppendText对象
                    {
                        sr = File.AppendText(FILE_NAME);
                    }
                    else    //如果文件不存在,则创建File.CreateText对象
                    {
                        sr = File.CreateText(FILE_NAME);
                    }
                    sr.WriteLine("finished");
                    sr.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            //curold = Cursor.Current;
            cur1 = new Cursor(LoadCursorFromFile(@"hammer.ani"));
            cur2 = new Cursor(LoadCursorFromFile(@"hit.cur"));
            times = score = 0;
            Picture1.Cursor = cur1;
            Picture2.Cursor = Picture1.Cursor;
            Picture3.Cursor = Picture1.Cursor;
            Picture4.Cursor = Picture1.Cursor;
            Picture5.Cursor = Picture1.Cursor;
            Picture6.Cursor = Picture1.Cursor;
            Picture7.Cursor = Picture1.Cursor;
            Picture8.Cursor = Picture1.Cursor;
            Picture9.Cursor = Picture1.Cursor; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(curold != null)
               // Cursor.Current = curold;
            MessageBox.Show("再见!");
            this.Close();
        }

        private void Picture1_MouseUp(object sender, MouseEventArgs e)
        {
            Picture1.Cursor = cur1;
        }

        private void Picture3_MouseUp(object sender, MouseEventArgs e)
        {
            Picture3.Cursor = cur1;
        }

        private void Picture5_MouseUp(object sender, MouseEventArgs e)
        {
            Picture5.Cursor = cur1;
        }

        private void Picture2_MouseUp(object sender, MouseEventArgs e)
        {
            Picture2.Cursor = cur1;
        }

        private void Picture4_MouseUp(object sender, MouseEventArgs e)
        {
            Picture4.Cursor = cur1;
        }

        private void Picture6_MouseUp(object sender, MouseEventArgs e)
        {
            Picture6.Cursor = cur1;
        }

        private void Picture7_MouseUp(object sender, MouseEventArgs e)
        {
            Picture7.Cursor = cur1;
        }

        private void Picture8_MouseUp(object sender, MouseEventArgs e)
        {
            Picture8.Cursor = cur1;
        }

        private void Picture9_MouseUp(object sender, MouseEventArgs e)
        {
            Picture9.Cursor = cur1;
        }



    }
}
