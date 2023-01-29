using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Fill All text box");
            }
            else
            {
               
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into student(RegistrationNumber, Name,Department, Session, CGPA, Address) values (@RegistrationNumber, @Name,@Department, @Session, @CGPA, @Address)", con);
                cmd.Parameters.AddWithValue("@RegistrationNumber", textBox1.Text);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Department", textBox3.Text);
                cmd.Parameters.AddWithValue("@Session", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@CGPA", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@Address", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == 0 || textBox9.Text == "Enter Registration Number")
            {

                MessageBox.Show("Enter Valid/Correct Registration Number");
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM student WHERE RegistrationNumber = @RegistrationNumber", con);
                cmd.Parameters.AddWithValue("@RegistrationNumber", textBox9.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 0 || textBox8.Text == "Enter Registration Number")
            {

                MessageBox.Show("Enter Valid/Correct Registration Number");
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from student where RegistrationNumber = @RegistrationNumber", con);
                cmd.Parameters.AddWithValue("@RegistrationNumber", textBox8.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt; ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
