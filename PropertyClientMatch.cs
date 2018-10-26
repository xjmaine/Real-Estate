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
    public partial class PropertyClientMatch : Form
    {
        DAL.Dal DL = new DAL.Dal();
        public PropertyClientMatch()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DL.cs);


            string query;
            query = "SELECT        Property_id, Ownername, Address, Mobile, Location, Sub_Location, Propertytype, PropertySubtype, rent_amt, lease_amt, sale_amt  FROM            Property   WHERE    (";

            if (!string.IsNullOrEmpty(cmbpropertytype.Text))
            {

                query += "Propertytype ='" + cmbpropertytype.Text + "' AND ";

            }
            if (!string.IsNullOrEmpty(cmbsubpropertytype.Text))
            {

                query += "PropertySubtype ='" + cmbsubpropertytype.Text + "' AND ";

            }
            if (!string.IsNullOrEmpty(cmblocation.Text))
            {

                query += "Location ='" + cmblocation.Text + "' AND ";

            }


            query = query.Remove(query.Length - 4, 3);


            query += ")";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "tt");
            dataGridView1.DataSource = ds.Tables["tt"];
            dataGridView1.AutoGenerateColumns = true;





            query = "SELECT Client_ID, Client_Name, Work_Address, Residence_Address, Location, Sub_location, Mobile, Phone, Email, Property_type   FROM            client  WHERE    (";

            if (!string.IsNullOrEmpty(cmbpropertytype.Text))
            {

                query += "Property_type ='" + cmbpropertytype.Text + "' AND ";

            }
            if (!string.IsNullOrEmpty(cmblocation.Text))
            {

                query += "Location ='" + cmblocation.Text + "' AND ";

            }


            query = query.Remove(query.Length - 4, 3);


            query += ")";
            SqlDataAdapter daa = new SqlDataAdapter(query, con);
            DataSet dsa = new DataSet();

            daa.Fill(dsa, "tt");
            dataGridView2.DataSource = dsa.Tables["tt"];


        }


        //Show Property Value
        public void SHOWPROPERTY()
        {
            cmbsubpropertytype.Items.Clear();
            cmbsubpropertytype.Text = "";
            if (cmbpropertytype.Text == "Residential")
            {
                cmbsubpropertytype.Items.Add("Apartment");
                cmbsubpropertytype.Items.Add("Bunglow");
                cmbsubpropertytype.Items.Add("Paying guest");
                cmbsubpropertytype.Items.Add("Row house");
                cmbsubpropertytype.Items.Add("Guest House");
                cmbsubpropertytype.Items.Add("House");
                cmbsubpropertytype.Items.Add("Site");

                ////////////////////////////////////////////////////////****************************************************************************/////////////////////////////////////////                  
                cmbsubpropertytype.Items.Add("Individual  PG");
                cmbsubpropertytype.Items.Add("Sharing PG");
                cmbsubpropertytype.Items.Add("Both(Sharing PG/Individual  PG)");
            }
            if (cmbpropertytype.Text == "Gated Community Layout")
            {
                cmbsubpropertytype.Items.Add("Row Houses");
                cmbsubpropertytype.Items.Add("Villas");
                cmbsubpropertytype.Items.Add("Gated Community Sites");
            }
            if (cmbpropertytype.Text == "Commercial")
            {

                cmbsubpropertytype.Items.Add("Shoping complex");
                cmbsubpropertytype.Items.Add("Business center");
                cmbsubpropertytype.Items.Add("Showroom space");
                cmbsubpropertytype.Items.Add("Godown");
                cmbsubpropertytype.Items.Add("Site");
                cmbsubpropertytype.Items.Add("Shoping complex");
                cmbsubpropertytype.Items.Add("Hotel");
                ////////////////////////////////////////////////////////****************************************************************************/////////////////////////////////////////
                cmbsubpropertytype.Items.Add("Office Space");
                cmbsubpropertytype.Items.Add("Land");

            }
            if (cmbpropertytype.Text == "Industrial")
            {

                cmbsubpropertytype.Items.Add("Industrial");
                cmbsubpropertytype.Items.Add("Factory");
                cmbsubpropertytype.Items.Add("Industrial unit");
                cmbsubpropertytype.Items.Add("Warehouse godown");
                cmbsubpropertytype.Items.Add("land");
            }
            if (cmbpropertytype.Text == "Service apartment")
            {
                cmbsubpropertytype.Items.Add("Hotels");
                cmbsubpropertytype.Items.Add("Corporates");
                cmbsubpropertytype.Items.Add("Others");
            }
            if (cmbpropertytype.Text == "Agricultural")
            {

                cmbsubpropertytype.Items.Add("Agricultural Land/Site");
                //////////**************************change************************************//
                cmbsubpropertytype.Items.Add("Gram Thana Land/Site");
                cmbsubpropertytype.Items.Add("Yellow Zone Land/Site");
                cmbsubpropertytype.Items.Add("Green Zone Land/Site");
                cmbsubpropertytype.Items.Add("Commercial Zone Land/Site");
            }
            if (cmbpropertytype.Text == "Joint venture")
            {
                cmbsubpropertytype.Items.Add("Commercial Land/Site");
                cmbsubpropertytype.Items.Add("Residential Land/Site");
                cmbsubpropertytype.Items.Add("Layouts Land/Site");
                cmbsubpropertytype.Items.Add("Apartment Land/Site");
                cmbsubpropertytype.Items.Add("Villas Land/Site");
            }
        }

        private void cmbpropertytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            SHOWPROPERTY();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            dataGridView1.DataSource = null;
            cmbpropertytype.Text = "";
            cmbsubpropertytype.Text = "";
            cmblocation.Text = "";
            comboBox4.Text = "";
           // textBox4.Text = "";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear(); 
        }

        private void PropertyClientMatch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realEstateDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.realEstateDataSet.Client);
            // TODO: This line of code loads data into the 'realEstateDataSet.Property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter.Fill(this.realEstateDataSet.Property);
            // TODO: This line of code loads data into the 'realEstateDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.realEstateDataSet.Client);
            // TODO: This line of code loads data into the 'realEstateDataSet.Property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter.Fill(this.realEstateDataSet.Property);

        }
    }
}
    

