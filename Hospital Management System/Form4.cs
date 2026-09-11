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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\pc\Documents\HMS2.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into doctor values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();
            MessageBox.Show("Data successfully inserted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from doctor where doctorid = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();
            MessageBox.Show("Data successfully deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update doctor set doctorid='" + textBox1.Text + "',doctorname = '" + textBox2.Text + "',doctorspecialisation='" + textBox3.Text + "',doctornumber = '" + textBox4.Text + "', gender='" + comboBox1.Text + "' where doctorid ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();
            MessageBox.Show("Data successfully updated");
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            comboBox1.Text = " ";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from doctor where doctorid = '" + textBox1.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                textBox2.Text = reader["doctorname"].ToString();
                textBox3.Text = reader["doctorspecialisation"].ToString();
                textBox4.Text = reader["doctornumber"].ToString();
                comboBox1.Text = reader["gender"].ToString();


                MessageBox.Show("Record found for Doctor ID: " + textBox1.Text);
            }
            else
            {
                MessageBox.Show("No record found with Doctor ID: " + textBox1.Text);

            }

            reader.Close();
            con.Close();
            displaydata();
        }
        public void displaydata()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from doctor";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

    }
}
