using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication8
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\pc\Documents\HMS2.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                using (SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM patient", con))
                {
                    textBox1.Text = cmd1.ExecuteScalar().ToString();
                }

                using (SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM doctor", con))
                {
                    textBox2.Text = cmd2.ExecuteScalar().ToString();
                }
                using (SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Appointmentdetails", con))
                {
                    textBox3.Text = cmd3.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);

            }

            con.Close();
        }
    }
}
