using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class next_principal_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtsrch_TextChanged(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["mirza"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM register WHERE rollno LIKE '%' + @rollno + '%' ";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@rollno", txtsrch.Text.Trim());
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataSourceID = string.Empty;
                    GridView1.DataBind();
                }
            }
        }
    }
    protected void reset_email_Click(object sender, EventArgs e)
    {
        // txtsrch.Text = string.Empty;
        Response.Redirect(Page.Request.RawUrl, false);

    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["mirza"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM register WHERE email LIKE '%' + @email + '%' ";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@email", txtemail.Text.Trim());
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataSourceID = string.Empty;
                    GridView1.DataBind();
                }
            }
        }
    }
    protected void txtname_TextChanged(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["mirza"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM register WHERE fname LIKE '%' + @name + '%' or lname LIKE '%' + @name + '%'";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataSourceID = string.Empty;
                    GridView1.DataBind();
                }
            }
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
            e.Row.Attributes["style"] = "cursor:pointer";
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string regid = GridView1.SelectedRow.Cells[0].Text;
        //Session["regid"] = regid;
        //Response.Redirect("update.aspx");
        if (GridView1.SelectedRow.Cells[14].Text.Equals("Cc"))
        {
            Session["regid"] = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("cc_profile.aspx");
        }
        else if (GridView1.SelectedRow.Cells[14].Text.Equals("Student"))
        {
            Session["regid"] = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("student_profile.aspx");
        }
        else if (GridView1.SelectedRow.Cells[14].Text.Equals("Hod"))
        {
            Session["regid"] = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("hod_profile.aspx");
        }
        else if (GridView1.SelectedRow.Cells[14].Text.Equals("Principle"))
        {
            Response.Redirect("profilepr.aspx");
        }
        else
        {
            Response.Redirect("update.aspx");
        }
    }
}