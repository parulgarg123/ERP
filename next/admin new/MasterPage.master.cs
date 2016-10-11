using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


public partial class next_admin_new_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }




    protected void Unnamed1_Click(object sender, EventArgs e)
    {

        Session.Abandon();
        Response.Redirect("~/admin.aspx");
    }
}
