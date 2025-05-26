using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string constr;

            // for the connection to 
            // sql server database
            SqlConnection conn;

            // Data Source is the name of the 
            // server on which the database is stored.
            // The Initial Catalog is used to specify
            // the name of the database
            // The UserID and Password are the credentials
            // required to connect to the database.
            constr = @"Data Source=103.140.219.50;Initial Catalog=Apico;User ID=Sa;Password=Securepass123@";

            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            // use to perform read and write
            // operations in the database
            SqlCommand cmd;

            // use to read a row in
            // table one by one
            SqlDataReader dreader;

            // to store SQL command and
            // the output of SQL command
            string sql;

            // use to fetch rows from demo table
            sql = "Select * from userrig";

            // to execute the sql statement
            cmd = new SqlCommand(sql, conn);

            // fetch all the rows 
            // from the demo table
            dreader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dreader);
            GridView1.DataSource = table;
            GridView1.DataBind();

            // to close all the objects
            dreader.Close();
            cmd.Dispose();
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr;

            // for the connection to 
            // sql server database
            SqlConnection conn;

            // Data Source is the name of the 
            // server on which the database is stored.
            // The Initial Catalog is used to specify
            // the name of the database
            // The UserID and Password are the credentials
            // required to connect to the database.
            constr = @"Data Source=103.140.219.50;Initial Catalog=Apico;User ID=Sa;Password=Securepass123@";

            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            // use to perform read and write
            // operations in the database
            SqlCommand cmd;

            // data adapter object is use to 
            // insert, update or delete commands
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";

            // use the defined sql statement
            // against our database
            sql = "insert into userrig (email,mobile,company,pass,date,status) values('"+TextBox1.Text+ "','"+TextBox2.Text+ "','"+TextBox3.Text+ "','"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"')";

            // use to execute the sql command so we 
            // are passing query and connection object
            cmd = new SqlCommand(sql, conn);

            // associate the insert SQL 
            // command to adapter object
            adap.InsertCommand = new SqlCommand(sql, conn);

            // use to execute the DML statement against
            // our database
            adap.InsertCommand.ExecuteNonQuery();

            // closing all the objects
            cmd.Dispose();
            conn.Close();
        }
    }
}