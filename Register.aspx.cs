using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        string fname = uname.Text;
        string lname = lname1.Text;
        string pass = TextBox1.Text;
        string email = TextEmail.Text;
        string phn = TextBox4.Text;
        string adr = TextBox5.Text;
        string pin = TextBox6.Text;

        try
        {
            String conn = "Server=localhost;Database=shopping;Uid=root;";

            MySqlConnection con = new MySqlConnection(conn);
           

            con.Open();
            String str = "insert into custdetail values('" + fname + "','" + lname + "','" + phn + "','" + email + "','" + pass + "','" + adr + "'," + pin + ");";
            MySqlCommand comm = new MySqlCommand(str, con);

            comm.ExecuteNonQuery();

            Label1.Text = "Successfully Registered :";

                       con.Close();
                       Context.Items.Add("Name", fname);
                       Server.Transfer("Default.aspx");
        }
        catch (MySqlException e1)
        {
            Label1.Text = e1.ToString();
        }

 
    }
}