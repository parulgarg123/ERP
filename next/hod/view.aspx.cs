using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class next_hod_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindGrid();
    }
    protected void Unnamed1_Click1(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["mirza"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM register WHERE rollno LIKE '%' + @rollno + '%' and dept='" + Session["dept_hod"] + "'and (acc_type='Student' or acc_type='Cc')";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@rollno", txtSearch.Text.Trim());
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
    private void BindGrid()
    {
        string constr = ConfigurationManager.ConnectionStrings["mirza"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM register WHERE rollno LIKE '%' + @rollno + '%' and dept='" + Session["dept_hod"] + "'and (acc_type='Student' or acc_type='Cc')";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@rollno", txtSearch.Text.Trim());
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        txtSearch.Text = string.Empty;
        Response.Redirect("view.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GridView1.SelectedRow.Cells[14].Text.Equals("Cc"))
        {
            Session["regid"] = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("cc_update.aspx");
        }
        else if (GridView1.SelectedRow.Cells[14].Text.Equals("Student"))
        {
            Session["regid"] = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("student_update.aspx");
        }
        else
        {
            Response.Redirect("update.aspx");
        }

    }
    public SortDirection dir
    {
        get
        {
            if (ViewState["dirState"] == null)
            {
                ViewState["dirState"] = SortDirection.Ascending;
            }
            return (SortDirection)ViewState["dirState"];
        }
        set
        {
            ViewState["dirState"] = value;
        }
    }
    private DataTable BindGridView()
    {
        DataTable dtGrid = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mirza"].ConnectionString);
        string strSelect = "SELECT * from register where  dept='" + Session["dept_hod"] + "'and (acc_type='Student' or acc_type='Cc')";
        SqlCommand cmd = new SqlCommand(strSelect, con);
        SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
        dAdapter.Fill(dtGrid);
        return dtGrid;
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
            e.Row.Attributes["style"] = "cursor:pointer";
        }
    }
    protected void doc_Click(object sender, EventArgs e)
    {
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=Student_det.doc");
        Response.ContentType = "application/word";

        StringWriter stringWriter = new StringWriter();
        HtmlTextWriter htmltextwriter = new HtmlTextWriter(stringWriter);

        GridView1.HeaderRow.Style.Add("background-color", "#FFFFFF");
        foreach (TableCell tablecell in GridView1.HeaderRow.Cells)
        {
            tablecell.Style["background-color"] = "#FFFFFF";
        }
        foreach (GridViewRow gridviewrow in GridView1.Rows)
        {
            gridviewrow.BackColor = System.Drawing.Color.White;
            foreach (TableCell gridviewrowtablecell in gridviewrow.Cells)
            {
                gridviewrowtablecell.Style["background-color"] = "#FFFFFF";
            }
        }

        GridView1.RenderControl(htmltextwriter);
        Response.Write(stringWriter.ToString());
        Response.End();
    }
    protected void excel_Click(object sender, EventArgs e)
    {
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=Student_det.xls");
        Response.ContentType = "application/excel";

        StringWriter stringWriter = new StringWriter();
        HtmlTextWriter htmltextwriter = new HtmlTextWriter(stringWriter);

        GridView1.HeaderRow.Style.Add("background-color", "#FFFFFF");
        foreach (TableCell tablecell in GridView1.HeaderRow.Cells)
        {
            tablecell.Style["background-color"] = "#FFFFFF";
        }
        foreach (GridViewRow gridviewrow in GridView1.Rows)
        {
            gridviewrow.BackColor = System.Drawing.Color.White;
            foreach (TableCell gridviewrowtablecell in gridviewrow.Cells)
            {
                gridviewrowtablecell.Style["background-color"] = "#FFFFFF";
            }
        }

        GridView1.RenderControl(htmltextwriter);
        Response.Write(stringWriter.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
    }
    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
    protected void GridView1_Sorting1(object sender, GridViewSortEventArgs e)
    {
        string sortingDirection = string.Empty;
        if (dir == SortDirection.Ascending)
        {
            dir = SortDirection.Descending;
            sortingDirection = "Desc";
        }
        else
        {
            dir = SortDirection.Ascending;
            sortingDirection = "Asc";
        }

        DataView sortedView = new DataView(BindGridView());
        sortedView.Sort = e.SortExpression + " " + sortingDirection;
        GridView1.DataSource = sortedView;
        GridView1.DataBind();
    }
    protected void txtsrch_TextChanged(object sender, EventArgs e)
    {

    }
    protected void reset_email_Click(object sender, EventArgs e)
    {
        txtsrch.Text = string.Empty;
        Response.Redirect("view.aspx");
    }
    protected void search_email_Click(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["mirza"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM register WHERE email LIKE '%' + @email + '%' and dept='" + Session["dept_hod"] + "'and (acc_type='Student' or acc_type='Cc')";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@email", txtsrch.Text.Trim());
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
}