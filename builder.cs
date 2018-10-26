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
    public partial class builder : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public builder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsAlpha(e);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlConnection con = new SqlConnection(dl.cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO Builder   (Builder_Name, Address, Company_Name, Location, Sub_location, Mobile, Phone, Email,  Property_type, Specialisation, Remarks) VALUES        ('" + txtName.Text + "','" + txtAddress.Text + "','" + comboCompany.Text + "','" + comboLocation1.Text + "','" + comboLocation2.Text + "','" + txtPhone.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + comboProperty1.Text + "','" + comboSpecialization.Text + "','" + txtRemark.Text + "')", con);
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

        //Clear Fields on Click Button
        private void btn_clear_Click(object sender, EventArgs e) => clear();

        void clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            comboCompany.Text = "";
            comboLocation1.Text = "";
            comboLocation2.Text = "";
            txtMobile.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            comboProperty1.Text = "";
            comboSpecialization.Text = "";
            txtRemark.Text = "";
        }

        //Builder ID
        void builderid()
        {
            SqlConnection con = new SqlConnection(dl.cs);
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Builder_ID) AS ID  FROM Builder", con);
            DataTable dt = new DataTable();
            int i = da.Fill(dt);
          /*  if (i < 0) ;
            {
                string k = Convert.ToString((Convert.ToInt32(dt.Rows[0][0])) + 1);
                txtName.Text = k;
            }*/
        }

        //Load event loading Build ID settings
        private void builder_Load(object sender, EventArgs e) => builderid();

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }
    }
}
