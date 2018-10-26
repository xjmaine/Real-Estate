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
    public partial class buildersearch : Form
    {
        DAL.Dal DL = new DAL.Dal();
        public buildersearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DL.cs);


            string query;
            query = "SELECT  Builder_ID, Name, Address, Company_Name, Location, Sub_location, Mobile, Phone, Email, Property_type, Specialisation, Remarks   FROM  Builder   WHERE    (";

            if (!string.IsNullOrEmpty(comboBox1.Text))
            {

                query += "Property_type ='" + comboBox1.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            if (!string.IsNullOrEmpty(comboBox4.Text))
            {

                query += "Location ='" + comboBox4.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            if (!string.IsNullOrEmpty(comboBox3.Text))
            {

                query += "Sub_location ='" + comboBox3.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            //if (!string.IsNullOrEmpty(textBox1.Text))
            //{

            //    query += "Name ='" + textBox1.Text + "' AND ";
            //    // (Owner_name LIKE '%saaj%')
            //}

            //if (!string.IsNullOrEmpty(textBox2.Text))
            //{

            //    query += "Company_Name ='" + textBox2.Text + "' AND ";
            //    // (Owner_name LIKE '%saaj%')
            //}

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

        private void buildersearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realEstateDataSet.Builder' table. You can move, or remove it, as needed.
            this.builderTableAdapter.Fill(this.realEstateDataSet.Builder);
            // TODO: This line of code loads data into the 'realEstateDataSet.Builder' table. You can move, or remove it, as needed.
            this.builderTableAdapter.Fill(this.realEstateDataSet.Builder);

        }
    }
}
