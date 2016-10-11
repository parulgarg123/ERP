using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using fee;

public partial class next_cc_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cod"] == null)
            Response.Redirect("~/cc.aspx");
        cc_name();
        Label1.Text = Convert.ToString(Session["name_cc"])+"'s Panel";
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/cc.aspx");
    }

    private void cc_name()
    {
        string abc = null;
        string abc2 = null;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mirza"].ConnectionString);
        conn.Open();
        SqlCommand command = new SqlCommand("Select * from [register] WHERE regid=" + Session["cod"], conn);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                abc = reader[1].ToString();
                abc2 = reader[2].ToString();
            }
        }
        Session["name_cc"] = abc + " " + abc2;
        conn.Close();
    }

}
