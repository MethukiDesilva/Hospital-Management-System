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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = textBox1.Text;
            password = textBox2.Text;

            if (username == "admin" && password == "admin@123")
            {
                this.Hide();
                Form2 obj1 = new Form2();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
