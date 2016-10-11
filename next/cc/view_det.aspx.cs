using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;


public partial class next_cc_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
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
        Session["dept"] = abc;
        BindGrid();
        conn.Close();
        //Label1.Text = abc;
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

        string regid = GridView1.SelectedRow.Cells[0].Text;
        Session["regid"] = regid;
        Response.Redirect("update.aspx");
    }
    protected void Unnamed1_Click1(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["mirza"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM register WHERE rollno LIKE '%' + @rollno + '%' and acc_type='Student'and dept='" + Session["dept"] + "'";
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
                cmd.CommandText = "SELECT * FROM register WHERE rollno LIKE '%' + @rollno + '%' and acc_type='Student' and dept='" + Session["dept"] + "'";
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
    protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
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
    private DataTable BindGridView()
    {
        DataTable dtGrid = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mirza"].ConnectionString);
        string strSelect = "SELECT * from register where acc_type='Student'and dept='" + Session["dept"] + "'";
        SqlCommand cmd = new SqlCommand(strSelect, con);
        SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
        dAdapter.Fill(dtGrid);
        return dtGrid;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        txtSearch.Text = string.Empty;
        Response.Redirect("view_det.aspx");
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
}