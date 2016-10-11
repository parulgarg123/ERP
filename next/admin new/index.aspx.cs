using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using fee;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class next_admin_new_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        reset_Click(this, new EventArgs());
        string css = "SELECT COUNT(*) FROM register where dept='Computer Science Engineering' AND acc_type='Student'";
        string cst = "SELECT COUNT(*) FROM register where dept='Computer Science Engineering' AND acc_type='Cc'";
        string cs = "SELECT COUNT(*) FROM register where dept='Civil Engineering' AND acc_type='Student'";
        string ct = "SELECT COUNT(*) FROM register where dept='Civil Engineering' AND acc_type='Cc'";
        string ms = "SELECT COUNT(*) FROM register where dept='Mechanical Engineering' AND acc_type='Student'";
        string mt = "SELECT COUNT(*) FROM register where dept='Mechanical Engineering' AND acc_type='Cc'";
        string ass = "SELECT COUNT(*) FROM register where dept='Applied Science' AND acc_type='Student'";
        string asst = "SELECT COUNT(*) FROM register where dept='Applied Science' AND acc_type='Cc'";
        string eces = "SELECT COUNT(*) FROM register where dept='Electronics And Communication Engineering' AND acc_type='Student'";
        string ecet = "SELECT COUNT(*) FROM register where dept='Electronics And Communication Engineering' AND acc_type='Cc'";
        int css1 = 0,cst1 = 0,cs1 = 0,ct1 = 0,ms1 = 0,mt1 = 0,ass1 = 0,asst1 = 0,eces1 = 0,ecet1 = 0;

        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mirza"].ConnectionString))
        {
            using (SqlCommand cmdCount = new SqlCommand(css, con))
            {
                con.Open();
                css1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(cst, con))
            {
                con.Open();
                cst1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(cs, con))
            {
                con.Open();
                cs1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(ct, con))
            {
                con.Open();
                ct1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(ms, con))
            {
                con.Open();
                ms1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(mt, con))
            {
                con.Open();
                mt1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(ass, con))
            {
                con.Open();
                ass1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(asst, con))
            {
                con.Open();
                asst1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(eces, con))
            {
                con.Open();
                eces1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            using (SqlCommand cmdCount = new SqlCommand(ecet, con))
            {
                con.Open();
                ecet1 = (int)cmdCount.ExecuteScalar();
                con.Close();
            }

            Label3.Text = Convert.ToString(ass1);
            Label2.Text = Convert.ToString(asst1);
            Label6.Text = Convert.ToString(css1);
            Label5.Text = Convert.ToString(cst1);
            Label9.Text = Convert.ToString(cs1);
            Label8.Text = Convert.ToString(ct1);
            Label11.Text = Convert.ToString(ms1);
            Label10.Text = Convert.ToString(mt1);
            Label13.Text = Convert.ToString(eces1);
            Label12.Text = Convert.ToString(ecet1);
            Label14.Text = Convert.ToString(asst1 + cst1 + ct1 + mt1 + ecet1);
            Label15.Text = Convert.ToString(ass1 + css1 + cs1 + ms1 + eces1);
            
        }
    }


    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        TextBox1.ReadOnly = true;
        GridView1.DataBind();
        if (GridView1.Rows.Count == 0)
        {
            Label16.Visible = true;
        }

    }



    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string regid = GridView1.SelectedRow.Cells[0].Text;

        Session["regid"] = regid;
        
        Response.Redirect("update.aspx");
    }

    protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
            e.Row.Attributes["style"] = "cursor:pointer";
        }
    }

    protected void reset_Click(object sender, EventArgs e)
    {
        TextBox1.ReadOnly = false;
        //TextBox1.Text = string.Empty;
        Label16.Visible = false;
       
    }
}
