using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Has connection string to User login credentials
/// </summary>
namespace WindowsFormsApp1.DAL
{
    class Dal
    {
        private string connectionString = "";
        public string cs = @"Data Source=KZORRE-ADMIN\SQLEXPRESS;Initial Catalog=RealEstate;Integrated Security=True";

        public Dal()
        {
            this.connectionString = cs;
        }

        public Dal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Dal(string server, string database)
        {
            this.connectionString = string.Format("Server={0};Database={1};Trusted_Connection=True;", server, database);
        }

        public Dal(string server, string database, string user, string pass)
        {
            this.connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};Trusted_Connection=False", server, database, user, pass);
        }

        public virtual string ConnectionString
        {
            get
            {
                return this.connectionString;
            }
            set
            {
                this.connectionString = value;
            }
        }

        public System.Data.DataSet EXECUTE_FOR_REPORT(string CMD)
        {
            System.Data.SqlClient.SqlConnection con;
            con = new System.Data.SqlClient.SqlConnection(this.ConnectionString);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(CMD, con);
            DataSet DS = new DataSet();

            adp.Fill(DS);
            con.Close();
            return DS;
        }
    }
}
