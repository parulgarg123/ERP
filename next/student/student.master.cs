using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class next_student_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cod"] == null)
            Response.Redirect("~/student.aspx");
        student_name();
        Label1.Text = Convert.ToString(Session["name_student"]) + "'s Panel";
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/student.aspx");
    }
    private void student_name()
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
        Session["name_student"] = abc + " " + abc2;
        conn.Close();
    }
}
