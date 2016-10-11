using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using fee;


public partial class next_cc_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dept_cc();
    }

    private void dept_cc()
    {
        string abc = null;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mirza"].ConnectionString);
        conn.Open();
        SqlCommand command = new SqlCommand("Select * from [register] WHERE regid=" + Session["cod"], conn);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                abc = reader[4].ToString();
            }
        }
        Session["dept_cc"] = abc;
        conn.Close();
    }
}