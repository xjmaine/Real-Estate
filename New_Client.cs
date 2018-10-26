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
    public partial class New_Client : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public New_Client()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtArea.Text = "";
            txtEmail.Text = "";
            ComboFurnished.Text = "";
            txtID.Text = "";
            txtLeaseAmount.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtRentAmount.Text = "";
            txtResidentialAddress.Text = "";
            txtSaleAmount.Text = "";
            txtWorkAddress.Text = "";
            ComboLocation1.Text = "";
            comboLocation2.Text = "";
            comboProperty1.Text = "";
            comboProperty2.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {

                SqlConnection con = new SqlConnection(dl.cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO Client (Client_Name, Work_Address, Residence_Address, Location, Sub_location, Mobile, Phone, Email, Property_type, Property_Subtype, Area, Rent, Lease, Sale, Rent_amt, Lease_amt, Sale_amt, Client_Type, Furnished, FeedBack) VALUES        ('" + txtName.Text + "','" + txtWorkAddress.Text + "','" + txtResidentialAddress.Text + "','" + ComboLocation1.Text + "','" + comboLocation2.Text + "','" + txtMobile.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + comboProperty1.Text + "','" + comboProperty2.Text + "','" + txtArea.Text + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "','" + checkBox3.Checked + "','" + txtRentAmount.Text + "','" + txtLeaseAmount.Text + "','" + txtSaleAmount.Text + "','" + ComboClientType.Text + "','" + ComboFurnished.Text + "','" + richTextBox1.Text + "')", con);
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsAlpha(e);
        }

        private void txtResidentialAddress_TextChanged(object sender, EventArgs e)
        {
            // Validation.IsAlphaNumeric(e);
            txtResidentialAddress.Cursor.GetType();
        }

        private void txtResidentialAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsAlphaNumeric(e);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }

        public void SHOWPROPERTY()
        {
            comboProperty2.Items.Clear();
            comboProperty2.Text = "";
            if (comboProperty1.Text == "Residential")
            {
                comboProperty2.Items.Add("Apartment");
                comboProperty2.Items.Add("Bunglow");
                comboProperty2.Items.Add("Paying guest");
                comboProperty2.Items.Add("Row house");
                comboProperty2.Items.Add("Guest House");
                comboProperty2.Items.Add("House");
                comboProperty2.Items.Add("Site");

                ////////////////////////////////////////////////////////****************************************************************************/////////////////////////////////////////                  
                comboProperty2.Items.Add("Individual  PG");
                comboProperty2.Items.Add("Sharing PG");
                comboProperty2.Items.Add("Both(Sharing PG/Individual  PG)");
            }
            if (comboProperty1.Text == "Gated Community Layout")
            {
                comboProperty2.Items.Add("Row Houses");
                comboProperty2.Items.Add("Villas");
                comboProperty2.Items.Add("Gated Community Sites");
            }
            if (comboProperty1.Text == "Commercial")
            {

                comboProperty2.Items.Add("Shoping complex");
                comboProperty2.Items.Add("Business center");
                comboProperty2.Items.Add("Showroom space");
                comboProperty2.Items.Add("Godown");
                comboProperty2.Items.Add("Site");
                comboProperty2.Items.Add("Shoping complex");
                comboProperty2.Items.Add("Hotel");
                ////////////////////////////////////////////////////////****************************************************************************/////////////////////////////////////////
                comboProperty2.Items.Add("Office Space");
                comboProperty2.Items.Add("Land");

            }
            if (comboProperty1.Text == "Industrial")
            {

                comboProperty2.Items.Add("Industrial");
                comboProperty2.Items.Add("Factory");
                comboProperty2.Items.Add("Industrial unit");
                comboProperty2.Items.Add("Warehouse godown");
                comboProperty2.Items.Add("land");
            }
            if (comboProperty1.Text == "Service apartment")
            {
                comboProperty2.Items.Add("Hotels");
                comboProperty2.Items.Add("Corporates");
                comboProperty2.Items.Add("Others");
            }
            if (comboProperty1.Text == "Agricultural")
            {

                comboProperty2.Items.Add("Agricultural Land/Site");
                //////////**************************change************************************//
                comboProperty2.Items.Add("Gram Thana Land/Site");
                comboProperty2.Items.Add("Yellow Zone Land/Site");
                comboProperty2.Items.Add("Green Zone Land/Site");
                comboProperty2.Items.Add("Commercial Zone Land/Site");
            }
            if (comboProperty1.Text == "Joint venture")
            {
                comboProperty2.Items.Add("Commercial Land/Site");
                comboProperty2.Items.Add("Residential Land/Site");
                comboProperty2.Items.Add("Layouts Land/Site");
                comboProperty2.Items.Add("Apartment Land/Site");
                comboProperty2.Items.Add("Villas Land/Site");
            }
        }//

        private void comboProperty1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SHOWPROPERTY();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtRentAmount.Enabled = true;
            }
            else
            {
                txtRentAmount.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtLeaseAmount.Enabled = true;
            }
            else
            {
                txtLeaseAmount.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                txtSaleAmount.Enabled = true;
            }
            else
            {
                txtSaleAmount.Enabled = false;
            }
        }

        private void txtRentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }

        private void txtLeaseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }

        private void txtSaleAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.IsInteger(e);
        }
    }
}
