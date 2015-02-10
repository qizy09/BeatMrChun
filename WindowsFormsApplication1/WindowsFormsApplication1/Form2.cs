using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private BeatRat fatherform;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(BeatRat d):this()
        {
            fatherform = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fatherform.textBox1.Text = textBox2.Text + ",欢迎您！";
            this.Close();
            //form1
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            fatherform.textBox1.Text = textBox2.Text + "欢迎您！";
            this.Close();
        }
    }
}
