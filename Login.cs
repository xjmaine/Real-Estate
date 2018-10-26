using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        DAL.Dal dl = new DAL.Dal();

        public Login()
        {
            //Thread for splash screen
            Thread t = new Thread(new ThreadStart(StrThreadForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
           
        }

        public void StrThreadForm()
        {
            Application.Run(new StartSplash());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(dl.cs);
            SqlDataAdapter da = new SqlDataAdapter(" SELECT        User_id  FROM    User_Info  WHERE   (User_Name = '" + textBox1.Text + "') AND (User_Password = '" + textBox2.Text + "')", con);
            DataTable dt = new DataTable();
            int i = da.Fill(dt);
            if (i > 0)
            {
                this.Hide();
                Welcome wk = new Welcome();
                wk.Show();

            }
            else
            {
                MessageBox.Show("User Name or Password Not Match");
                clear();
            }
        }

        void clear()
        {
            //textBox1.Text = "";
            textBox2.Text = "";
        }

       

       

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
