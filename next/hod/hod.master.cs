using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using fee;


public partial class next_hod_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cod"] == null)
            Response.Redirect("~/hod.aspx");
        hod_name();
        Label1.Text = Convert.ToString(Session["name_hod"]) + "'s Panel";
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/hod.aspx");
    }
    private void hod_name()
    {
        string abc = null;
        string abc2 = null;
        string abc3 = null;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mirza"].ConnectionString);
        conn.Open();
        SqlCommand command = new SqlCommand("Select * from [register] WHERE regid=" + Session["cod"], conn);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                abc = reader[1].ToString();
                abc2 = reader[2].ToString();
                abc3 = reader[4].ToString();
            }
        }
        Session["name_hod"] = abc + " " + abc2;
        Session["dept_hod"] = abc3;
        conn.Close();
    }    
}
