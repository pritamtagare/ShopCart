using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class tees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String conn = "Server=localhost;Database=shopping;Uid=root;";

        MySqlConnection con = new MySqlConnection(conn);

        con.Open();
        String str = "select * from tees ;";
        MySqlCommand comm = new MySqlCommand(str, con);

        MySqlDataReader dr = comm.ExecuteReader();
        while(dr.Read())
        {
            string desc = dr[1].ToString();
            int price = Convert.ToInt32(dr[2]);
            string imgd= dr[3].ToString();
            Page.Controls.Add(new LiteralControl("<div class=\"column\"> <div class=\"card\"><img src=Images/"+imgd+" alt=\"Avatar\" style=\"width:100%\"> <p>"+price+"</p> <p>"+desc+"</p> </div></div> </div>"));
           
        }
        con.Close();
    }
}