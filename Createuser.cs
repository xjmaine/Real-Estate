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
    public partial class Createuser : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public Createuser()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUserPassword.Text != "")
            {
                SqlConnection con = new SqlConnection(dl.cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO User_Info (User_Name, User_Password, User_type, Comments) VALUES        ('" + txtUserName.Text + "','" + txtUserPassword.Text + "','" + cmbUserType.Text + "','" + txtNotes.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                user_info();
                MessageBox.Show("User Created");

            }
            else
            {
                MessageBox.Show("Enter User Name and Password");
            }
        }

        void user_info()
        {
            SqlConnection con = new SqlConnection(dl.cs);
            SqlDataAdapter da = new SqlDataAdapter("SELECT User_ID, User_Name, User_Password, User_type, Comments  FROM  User_Info", con);
            DataTable dt = new DataTable();
            int i = da.Fill(dt);
            if (i < 0) ;
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;

            }
        }

        private void Creatuser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realEstateDataSet.User_Info' table. You can move, or remove it, as needed.
           // this.user_InfoTableAdapter.Fill(this.realEstateDataSet.User_Info);
            // TODO: This line of code loads data into the 'realEstateDataSet.User_Info' table. You can move, or remove it, as needed.
           // this.user_InfoTableAdapter.Fill(this.realEstateDataSet.User_Info);
           

            user_info();
        }


        void clear()
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            cmbUserType.Text = "";
            txtNotes.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Welcome we = new Welcome();
            we.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
