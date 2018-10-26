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
    public partial class agent_search : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public agent_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(dl.cs);
            string query;
            query = "SELECT Agent_ID, Client_Name, Company_name, Address, Location, Sub_location, Mobile, Phone, Email, Property_type, Specialization, Remarks FROM     Agent  WHERE      (";

            if (!string.IsNullOrEmpty(txtpropertytype.Text))
            {

                query += "Property_type ='" + txtpropertytype.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {

                query += "Location ='" + comboBox1.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            if (!string.IsNullOrEmpty(comboBox2.Text))
            {

                query += "Sub_location ='" + comboBox2.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {

                query += "Client_Name ='" + textBox4.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }



            query = query.Remove(query.Length - 4, 3);


            query += ")";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "tt");
            dataGridView1.DataSource = ds.Tables["tt"];
            //     dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = false;
            int cnt = ds.Tables["tt"].Rows.Count;
            label2.Text = cnt.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            dataGridView1.DataSource = null;
            txtpropertytype.Text = "";
            cmbsubtype.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void agent_search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realEstateDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.realEstateDataSet.Client);
            // TODO: This line of code loads data into the 'realEstateDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.realEstateDataSet.Client);
            // TODO: This line of code loads data into the 'realEstateDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.realEstateDataSet.Client);

        }
    }
}
