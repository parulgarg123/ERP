using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cod"] == null)
            Response.Redirect("~/principal.aspx");
        principal();
        Label1.Text = Convert.ToString(Session["name_principle"]) + "'s Panel";
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/principal.aspx");
    }
    private void principal()
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
        Session["name_principle"] = abc + " " + abc2;
       
        conn.Close();
    }
}
