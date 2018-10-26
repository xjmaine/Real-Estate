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
    public partial class AuthenticateUser : Form
    {
        DAL.Dal dl = new DAL.Dal();
        public AuthenticateUser()
        {
            InitializeComponent();
        }

        int ConSqlInstance()
        {
            SqlConnection con = new SqlConnection(dl.cs);
            SqlDataAdapter da = new SqlDataAdapter(" SELECT        User_id  FROM    User_Info  WHERE   (User_Name = '" + txtUsername.Text + "') AND (User_Password = '" + txtPassword.Text + "')", con);
            DataTable dt = new DataTable();
            int i = da.Fill(dt);

            return i;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool btnSave_Click = false;

            /* SqlConnection con = new SqlConnection(dl.cs);
             SqlDataAdapter da = new SqlDataAdapter(" SELECT        User_id  FROM    User_Info  WHERE   (User_Name = '" + txtUsername.Text + "') AND (User_Password = '" + txtPassword.Text + "')", con);
             DataTable dt = new DataTable();
             int i = da.Fill(dt);*/
            
            
            if (ConSqlInstance() > 0)
            {
                this.Hide();
                Createuser cu = new Createuser();
                cu.Show();

                if (btnSave_Click == true)
                {
                    Welcome wc = new Welcome();
                    wc.Show();
                }

                else
                {
                    MessageBox.Show("Null values, trye again...");
                }

            }
            else
            {
                MessageBox.Show("User Name or Password Not Match");
                clear();
            }
        }

        void clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome wc = new Welcome();
            wc.Show();
        }
    }
}
