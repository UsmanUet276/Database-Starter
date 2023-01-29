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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02_Task_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 || textBox1.Text == "Enter Registration Number" || textBox2.Text.Length == 0 || textBox2.Text == "Enter Data" || comboBox1.Text == "(Select)") {
                MessageBox.Show("Enter/Select valid Info");
            }
            else
            {
                        if (comboBox1.Text == "Name")
                        {
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("UPDATE student SET Name = @Name WHERE RegistrationNumber = @RegistrationNumber", con);
                            cmd.Parameters.AddWithValue("@RegistrationNumber", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Updated");
                        }
                        else if (comboBox1.Text == "Department")
                        {
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("UPDATE student SET Department = @Department WHERE RegistrationNumber = @RegistrationNumber", con);
                            cmd.Parameters.AddWithValue("@RegistrationNumber", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Department", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Updated");
                        }
                        else if (comboBox1.Text == "Session")
                        {
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("UPDATE student SET Session = @Session WHERE RegistrationNumber = @RegistrationNumber", con);
                            cmd.Parameters.AddWithValue("@RegistrationNumber", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Session", int.Parse(textBox2.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Updated");
                        }
                        else if (comboBox1.Text == "CGPA")
                        {
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("UPDATE student SET CGPA = @CGPA WHERE RegistrationNumber = @RegistrationNumber", con);
                            cmd.Parameters.AddWithValue("@RegistrationNumber", textBox1.Text);
                            cmd.Parameters.AddWithValue("@CGPA", int.Parse(textBox2.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Updated");
                        }
                        else if (comboBox1.Text == "Address")
                        {
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("UPDATE student SET Address = @Address WHERE RegistrationNumber = @RegistrationNumber", con);
                            cmd.Parameters.AddWithValue("@RegistrationNumber", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Address", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Updated");
                        }
                
            }
        }
    }
}
