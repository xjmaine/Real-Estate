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

namespace WindowsFormsApp1
{
    public partial class agent : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public agent()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(dl.cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO Agent  (Name, Company_name, Address, Location, Sub_location, Mobile, Phone, Email, Property_type, Specialization, Remarks)  VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox11.Text + "','" + comboBox4.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Enter All the Fields");
            }
        }

        void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox11.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsAlpha(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsAlpha(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsAlphaNumeric(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }
    }
}
