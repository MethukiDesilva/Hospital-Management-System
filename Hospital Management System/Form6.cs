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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\pc\Documents\HMS2.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into medicalrecord values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')";
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
            cmd.CommandText = " delete from medicalrecord where patientid = '" + textBox1.Text + "'";
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
            cmd.CommandText = "update medicalrecord set patientid='" + textBox1.Text + "',patientname = '" + textBox2.Text + "',patientage='" + textBox3.Text + "',symptoms = '" + textBox4.Text + "', bloodgroup='" + textBox5.Text + "', gender='" + comboBox1.Text + "' where patientid ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();
            MessageBox.Show("Data successfully updated");
        }
        public void displaydata()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from medicalrecord";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           textBox1.Text = " ";
           textBox2.Text = " ";
           textBox3.Text = " ";
           textBox4.Text = " ";
           textBox5.Text = " ";
           comboBox1.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from medicalrecord where patientid = '" + textBox1.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                //textBox1.Text = reader["patientid"].ToString();
                textBox2.Text = reader["patientname"].ToString();
                textBox3.Text = reader["patientage"].ToString();
                textBox4.Text = reader["symptoms"].ToString();
                textBox5.Text = reader["bloodgroup"].ToString();
                comboBox1.Text = reader["gender"].ToString();


                MessageBox.Show("Record found for Patient ID: " + textBox1.Text);
            }
            else
            {
                MessageBox.Show("No record found with Patient ID: " + textBox1.Text);

            }

            reader.Close();
            con.Close();
          
           
        }
    }
}
