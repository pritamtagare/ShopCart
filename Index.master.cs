using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string name = string.Format(Context.Items["Name"].ToString());
            Label1.Text = name;
        }
        catch (NullReferenceException ex)
        {
            
        } 
    }
}
