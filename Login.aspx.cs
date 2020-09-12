using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   
    protected void Button1_Click1(object sender, EventArgs e)
    {
        string pno = uname.Text;
        string pass = upass.Text;
        String conn = "Server=localhost;Database=shopping;Uid=root;";

        MySqlConnection con = new MySqlConnection(conn);

        con.Open();
        String str = "select fname , phoneno , password from custdetail where phoneno = '" + pno + "';";
        MySqlCommand comm = new MySqlCommand(str, con);

        MySqlDataReader dr = comm.ExecuteReader();
        dr.Read();
        if (pass == dr[2].ToString())
        {
            string name = dr[0].ToString();
            Context.Items.Add("Name", name);
            Server.Transfer("Default.aspx");

        }
        con.Close();
    }
    
}