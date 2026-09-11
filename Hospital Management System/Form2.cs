using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form4 obj1 = new Form4();
            obj1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 obj2 = new Form3();
            obj2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form5 obj3 = new Form5();
            obj3.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 obj4 = new Form6();
            obj4.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 obj5 = new Form8();
            obj5.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 obj6 = new Form7();
            obj6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 obj7 = new Form9();
            obj7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
