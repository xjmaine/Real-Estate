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

/// <summary>
///Residencial
/// Commercial
/// Agricultural
/// </summary>
namespace WindowsFormsApp1
{
    public partial class Property : Form
    {
        DAL.Dal dl = new DAL.Dal();
        int idp;

        public Property()
        {
            InitializeComponent();
        }

        private void Property_Load(object sender, EventArgs e)
        {
            PropertyID();
        }

        public Property(int i)
        {
            InitializeComponent();
            btnSave.Text = "Update";
            idp = i;
            showprop();
        }


        //Property ID method
        void showprop()
        {
            SqlConnection con = new SqlConnection(dl.cs);
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT OwnerName, Address, Mobile, Location, Sub_location, Property_type, Property_Subtype, MangedBy, Rent, Lease, Sale, Rent_amt, Lease_amt, Sale_amt  FROM    Property  WHERE (Property_ID = " + idp + ")", con);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);
                if (i > 0)
                {
                    txtID.Text = idp.ToString();
                    txtOwnerName.Text = dt.Rows[0][0].ToString();
                    txtOwnerAddress.Text = dt.Rows[0][1].ToString();
                    txtMobile.Text = dt.Rows[0][2].ToString();
                    ComboLocation1.Text = dt.Rows[0][3].ToString();
                    ComboLocation2.Text = dt.Rows[0][4].ToString();
                    comboProperty1.Text = dt.Rows[0][5].ToString();
                    comboProperty2.Text = dt.Rows[0][6].ToString();
                    //     string mangaby = dt.Rows[0][7].ToString();
                    //  if (dt.Rows[0][7].ToString() == "Self")
                    //    rbself.Checked = true;
                    //else
                    //   rbmbk.Checked=true;
                    checkBox1.Checked = Convert.ToBoolean(dt.Rows[0][8].ToString());
                    checkBox2.Checked = Convert.ToBoolean(dt.Rows[0][9].ToString());
                    checkBox3.Checked = Convert.ToBoolean(dt.Rows[0][10].ToString());
                    txtRentAmount.Text = dt.Rows[0][11].ToString();
                    txtLeaseAmount.Text = dt.Rows[0][12].ToString();
                    txtSaleAmount.Text = dt.Rows[0][13].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
           // {
                if (txtOwnerName.Text != "")
                {


                    if (btnSave.Text == "Save")
                    {
                        SqlConnection con = new SqlConnection(dl.cs);
                        SqlCommand cmd = new SqlCommand("INSERT INTO Property (Ownername, Address,  Location,  Sub_location, Mobile, Phone, Email, Property_type, Property_Subtype, Rent, Lease, Sale, Rent_amt, Lease_amt, Sale_amt, Remarks)   VALUES        ('" + txtOwnerName.Text + "','" + txtOwnerAddress.Text + "','" + ComboLocation1.Text + "','" + ComboLocation2.Text + "','" + txtMobile.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','"+comboProperty1.Text+ "','" + comboProperty2.Text + "','" + txtManagedBy.Text + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "','" + checkBox3.Checked + "','" + txtRentAmount.Text + "','" + txtLeaseAmount.Text + "','" + txtSaleAmount.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("your data is saved");
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(dl.cs);
                        SqlCommand cmd = new SqlCommand("UPDATE  Property  SET   Ownername ='" + txtOwnerAddress.Text + "', Address ='" + txtOwnerAddress.Text + "', Location ='" + ComboLocation1.Text + "', Sub_location ='" + ComboLocation2.Text + "', Mobile ='" + txtMobile.Text + "', Phone ='" + txtPhone.Text + "', Email ='" + txtEmail.Text + "', Property_type ='" + comboProperty1.Text + "', Property_Subtype ='" + comboProperty2.Text + "', ManagedBy ='" + txtManagedBy.Text + "', Rent ='" + checkBox1.Checked + "', Lease ='" + checkBox2.Checked + "', Sale ='" + checkBox3.Checked + "', Rent_amt ='" + txtRentAmount.Text + "', Lease_amt ='" + txtLeaseAmount.Text + "', Sale_amt = '" + txtSaleAmount.Text + "' WHERE  (Property_ID ='" + txtID.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Your data has been updated!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter All Fields");
                }
            //}


           /* catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void comboProperty1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SHOWPROPERTY();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Enabled = true;
            }
            else
            {
                checkBox3.Enabled = false;
            }
        }

        void clear()
        {
            txtOwnerName.Text = "";
            txtOwnerAddress.Text = "";
            ComboLocation1.Text = "";
            ComboLocation2.Text = "";
            txtMobile.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            comboProperty1.Text = "";
            comboProperty2.Text = "";
            txtManagedBy.Text = "";
            checkBox1.Text = "";
            checkBox2.Text = "";
            checkBox3.Text = "";
            txtRentAmount.Text = "";
            txtLeaseAmount.Text = "";
            txtSaleAmount.Text = "";
            
        }

        void PropertyID()
        {
            SqlConnection con = new SqlConnection(dl.cs);
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Property_ID) AS Expr1 FROM  Property  ", con);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);
                if (i > 0)
                {
                    string k = Convert.ToString((Convert.ToInt32(dt.Rows[0][0])) + 1);
                    txtID.Text = k;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
