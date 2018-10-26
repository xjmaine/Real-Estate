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
    public partial class ownersearch : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public ownersearch()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(dl.cs);
            string query;
            query = "SELECT Owner_ID, Name, Address, Location, Sub_location, Mobile, Phone, Email, Property_type, Remark  FROM   Owner_Detail WHERE   (";


            if (!string.IsNullOrEmpty(comboBox1.Text))
            {

                query += "Property_type ='" + comboBox1.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            if (!string.IsNullOrEmpty(comboBox3.Text))
            {

                query += "Location ='" + comboBox3.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            if (!string.IsNullOrEmpty(comboBox2.Text))
            {

                query += "Sub_location ='" + comboBox2.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                query += "Name ='" + textBox1.Text + "' AND ";
                // (Owner_name LIKE '%saaj%')

            }
            query = query.Remove(query.Length - 4, 3);


            query += ")";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "tt");
            dataGridView1.DataSource = ds.Tables["tt"];
            dataGridView1.AutoGenerateColumns = true;

            int cnt = ds.Tables["tt"].Rows.Count;
            label7.Text = cnt.ToString();
        }
    }
}
