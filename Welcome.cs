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
    public partial class Welcome : Form
    {
        private int childFormNumber = 0;
        DAL.Dal DL = new DAL.Dal ();

        public Welcome()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }



        private void Welcome_Load(object sender, EventArgs e)
        {
            totalclient();
            totalProperty();
        }

        void totalclient()
        {
            SqlConnection con = new SqlConnection(DL.cs);


            string query;
            query = "SELECT   * FROM    client";


            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tt");
            int cnt = ds.Tables["tt"].Rows.Count;
            lblclient.Text = cnt.ToString();

        }
        void totalProperty()
        {
            SqlConnection con = new SqlConnection(DL.cs);


            string query;
            query = "SELECT *  FROM     Property";


            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tt");
            int cnt = ds.Tables["tt"].Rows.Count;
            //  lblproperty.Text = cnt.ToString();

        }

       

        

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Client nc = new New_Client();
            nc.Show();
            nc.MdiParent = this;
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner ow = new Owner();
            ow.Show();
            ow.MdiParent = this;
        }

        private void agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agent ag = new agent();
            ag.Show();
            ag.MdiParent = this;
        }

        private void builderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            builder bd = new builder();
            bd.Show();
            bd.MdiParent = this;
        }

        private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Property pro = new Property();
            pro.Show();
            pro.MdiParent = this;
        }

        private void clientSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsearch cs = new clientsearch();
            cs.Show();
            cs.MdiParent = this;
        }

        private void agentSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agent ag = new agent();
            ag.Show();
            ag.MdiParent = this;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ownersearch os = new ownersearch();
            os.Show();
            os.MdiParent = this;
        }

        private void builderSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            builder bd = new builder();
            bd.Show();
            bd.MdiParent = this;
        }

        private void propertySearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPropertySearch sp = new NewPropertySearch();
            sp.Show();
            sp.MdiParent = this;
        }

        private void propertyClientMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyClientMatch pc = new PropertyClientMatch();
            pc.Show();
            pc.MdiParent = this;
        }

        private void clientReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientReport cr = new ClientReport();
            cr.Show();
            cr.MdiParent = this;
        }

        

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Createuser cu = new Createuser();
            AuthenticateUser au = new AuthenticateUser();
           // cu.Show();
           // cu.MdiParent = this;

            this.Hide();
            au.Show();

            //Add authentication here
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
