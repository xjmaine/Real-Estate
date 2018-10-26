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
    public partial class NewPropertySearch : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public NewPropertySearch()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            comboProperty1.Text = "";
            comboproperty2.Text = "";
            txtOwnerName.Text = "";
            comboLocation1.Text = "";
            comboLocation2.Text = "";
            label8.Text = "0";
            dataGridView1.DataSource = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboProperty1.Text != "")
            {
                SqlConnection con = new SqlConnection(dl.cs);
                string query;
                query = "SELECT Property_id, Ownername, Address, Mobile, Location, Sub_Location, Propertytype, PropertySubtype, rent, lease, sale, rent_amt  FROM  Property WHERE         (";




                if (!string.IsNullOrEmpty(comboProperty1.Text))
                {

                    query += "Property_type ='" + comboProperty1.Text + "' AND ";

                }
                if (!string.IsNullOrEmpty(comboLocation1.Text))
                {

                    query += "Location ='" + comboLocation1.Text + "' AND ";

                }
                if (!string.IsNullOrEmpty(comboLocation2.Text))
                {

                    query += "Sub_location ='" + comboLocation2.Text + "' AND ";

                }
                if (!string.IsNullOrEmpty(txtOwnerName.Text))
                {

                    query += "Name ='" + txtOwnerName.Text + "' AND ";

                    if (!string.IsNullOrEmpty(comboproperty2.Text))
                    {

                        query += "PropertySubType ='" + comboproperty2.Text + "' AND ";

                    }

                }
                query = query.Remove(query.Length - 4, 3);


                query += ")";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();

                da.Fill(ds, "tt");
                dataGridView1.DataSource = ds.Tables["tt"];
                dataGridView1.AutoGenerateColumns = true;

                int cnt = ds.Tables["tt"].Rows.Count;
                label8.Text = cnt.ToString();
            }
            else
            {
                MessageBox.Show("Select Fields to search");
            }
        }
    }
}
