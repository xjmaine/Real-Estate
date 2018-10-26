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
    public partial class Owner : Form
    {
        DAL.Dal dl = new DAL.Dal();

        public Owner()
        {
            InitializeComponent();
        }

        private void txtOwnerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsAlpha(e);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOwnerName.Text != "")
            {
                SqlConnection con = new SqlConnection(dl.cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO Owner_Detail (Owner_Name, Address, Location, Sub_location, Mobile, Phone, Email,Property_type, Remarks)VALUES        ('" + txtOwnerName.Text + "','" + txtAddress.Text + "','" + comboLocation1.Text + "','" + comboLocation2.Text + "','" + txtMobile.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + comboProperty1.Text + "','" + txtRemark.Text + "') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data is Saved");
            }
            else
            {
                MessageBox.Show("Enter All the Fields");
            }
        }

        void owner_id()
        {
            try
            {
                SqlConnection con = new SqlConnection(dl.cs);
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Owner_ID) AS Expr1 FROM Owner_Detail", con);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);
                if (i > 0)
                {
                    {
                        string k = Convert.ToString((Convert.ToInt32(dt.Rows[0][0])) + 1);
                        txtOwnerID.Text = k;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtOwnerID.Text = "1";
            }
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            owner_id();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtOwnerName.Text = "";
            txtAddress.Text = "";
            comboLocation1.Text = "";
            comboLocation2.Text = "";
            txtMobile.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            comboProperty1.Text = "";
            txtRemark.Text = "";
        }
    }
}
