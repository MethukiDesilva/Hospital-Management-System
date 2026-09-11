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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\pc\Documents\HMS2.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form5_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into appointmentdetails values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+textBox6.Text+"')";
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
            cmd.CommandText = " delete from appointmentdetails where patientid = '" + textBox1.Text + "'";
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
            cmd.CommandText = "update appointmentdetails set patientid='" + textBox1.Text + "',patientage = '" + textBox2.Text + "',doctorname='" + textBox3.Text + "',date = '" + textBox4.Text + "', appointmentnumber='" + textBox5.Text + "', appointmentfee='"+textBox6.Text+"' where patientid ='" + textBox1.Text + "'";
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
            cmd.CommandText = "select * from appointmentdetails";
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
            textBox6.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from appointmentdetails where patientid = '" + textBox1.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                textBox2.Text = reader["patientage"].ToString();
                textBox3.Text = reader["doctorname"].ToString();
                textBox4.Text = reader["date"].ToString();
                textBox5.Text = reader["appointmentnumber"].ToString();
                textBox6.Text = reader["appointmentfee"].ToString();


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
