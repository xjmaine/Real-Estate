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
    public partial class clientsearch : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public clientsearch()
        {
            InitializeComponent();
        }

        //Clear input
        void clear()
        {
            dataGridView1.DataSource = null;
            cmbpropertytype.Text = "";
            cmbsubtype.Text = "";
        }

        //Select Client
        void Client()
        {
            AutoCompleteStringCollection autosource = new AutoCompleteStringCollection();
            string Query = "SELECT DISTINCT Name FROM  Client  ";
            DataSet ds = dl.EXECUTE_FOR_REPORT(Query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                autosource.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            
        }

        public void SHOWPROPERTY()
        {
            cmbsubtype.Items.Clear();
            cmbsubtype.Text = "";
            if (cmbpropertytype.Text == "Residential")
            {
                cmbsubtype.Items.Add("Apartment");
                cmbsubtype.Items.Add("Bunglow");
                cmbsubtype.Items.Add("Paying guest");
                cmbsubtype.Items.Add("Row house");
                cmbsubtype.Items.Add("Guest House");
                cmbsubtype.Items.Add("House");
                cmbsubtype.Items.Add("Site");

                ////////////////////////////////////////////////////////****************************************************************************/////////////////////////////////////////                  
                cmbsubtype.Items.Add("Individual  PG");
                cmbsubtype.Items.Add("Sharing PG");
                cmbsubtype.Items.Add("Both(Sharing PG/Individual  PG)");
            }
            if (cmbpropertytype.Text == "Gated Community Layout")
            {
                cmbsubtype.Items.Add("Row Houses");
                cmbsubtype.Items.Add("Villas");
                cmbsubtype.Items.Add("Gated Community Sites");
            }
            if (cmbpropertytype.Text == "Commercial")
            {

                cmbsubtype.Items.Add("Shoping complex");
                cmbsubtype.Items.Add("Business center");
                cmbsubtype.Items.Add("Showroom space");
                cmbsubtype.Items.Add("Godown");
                cmbsubtype.Items.Add("Site");
                cmbsubtype.Items.Add("Shoping complex");
                cmbsubtype.Items.Add("Hotel");
                ////////////////////////////////////////////////////////****************************************************************************/////////////////////////////////////////
                cmbsubtype.Items.Add("Office Space");
                cmbsubtype.Items.Add("Land");

            }
            if (cmbpropertytype.Text == "Industrial")
            {

                cmbsubtype.Items.Add("Industrial");
                cmbsubtype.Items.Add("Factory");
                cmbsubtype.Items.Add("Industrial unit");
                cmbsubtype.Items.Add("Warehouse godown");
                cmbsubtype.Items.Add("land");
            }
            if (cmbpropertytype.Text == "Service apartment")
            {
                cmbsubtype.Items.Add("Hotels");
                cmbsubtype.Items.Add("Corporates");
                cmbsubtype.Items.Add("Others");
            }
            if (cmbpropertytype.Text == "Agricultural")
            {

                cmbsubtype.Items.Add("Agricultural Land/Site");
                //////////**************************change************************************//
                cmbsubtype.Items.Add("Gram Thana Land/Site");
                cmbsubtype.Items.Add("Yellow Zone Land/Site");
                cmbsubtype.Items.Add("Green Zone Land/Site");
                cmbsubtype.Items.Add("Commercial Zone Land/Site");
            }
            if (cmbpropertytype.Text == "Joint venture")
            {
                cmbsubtype.Items.Add("Commercial Land/Site");
                cmbsubtype.Items.Add("Residential Land/Site");
                cmbsubtype.Items.Add("Layouts Land/Site");
                cmbsubtype.Items.Add("Apartment Land/Site");
                cmbsubtype.Items.Add("Villas Land/Site");
            }
        }

        private void cmbpropertytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            SHOWPROPERTY();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(dl.cs);


                string query;
                query = "SELECT  Client_ID, Client_Name, Work_Address, Residence_Address, Location, Sub_location, Mobile, Phone, Email, Property_type, Property_Subtype, Area, Rent, Lease, Sale, Rent_amt, Lease_amt, Sale_amt, Client_type, Accommodation, Furnished, FeedBack  FROM  Client  WHERE    (";

                if (!string.IsNullOrEmpty(cmbpropertytype.Text))
                {

                    query += "Property_type ='" + cmbpropertytype.Text + "' AND ";

                }
                if (!string.IsNullOrEmpty(cmbsubtype.Text))
                {

                    query += "Property_Subtype ='" + cmbsubtype.Text + "' AND ";

                }
                



                query = query.Remove(query.Length - 4, 3);


                query += ")";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                dataGridView1.AutoGenerateColumns = false;
                da.Fill(ds, "tt");
                dataGridView1.DataSource = ds.Tables["tt"];


                int cnt = ds.Tables["tt"].Rows.Count;
                label2.Text = cnt.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Enter the Field values left Empty");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void clientsearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realEstateDataSet.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter.Fill(this.realEstateDataSet.Client);
            // TODO: This line of code loads data into the 'realEstateDataSet.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter.Fill(this.realEstateDataSet.Client);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
