using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using fee;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (Page.IsPostBack == false)
        {
            if (Request.Cookies["email"] != null && Request.Cookies["password"] != null)
            {
                username.Text = Request.Cookies["email"].Value;
                password.Attributes["value"] = Request.Cookies["password"].Value;
            }
        }
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        clsregister obj = new clsregister();
        clsregistrationprp objprp = new clsregistrationprp();
        objprp.email = username.Text;
        objprp.password = password.Text;


        try
        {

          int a= obj.parent_login(objprp);
            int b=obj.parent_login(objprp);
            Session["cod"] = a;
            Session["stu"] = b;
            if(Convert.ToInt32 ( Session["cod"])!=0)
            {
                Response.Redirect("next/parent/detailpa.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "invalid Email Password";
            }
           
        }
        catch (Exception exp)
        {
            Label1.Visible = true;
            Label1.Text = "Error!!!";
        }
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            Response.Cookies["email"].Expires = DateTime.Now.AddDays(30);
            Response.Cookies["password"].Expires = DateTime.Now.AddDays(30);
        }
        else
        {
            Response.Cookies["email"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);

        }
        Response.Cookies["email"].Value = username.Text.Trim();
        Response.Cookies["password"].Value = password.Text.Trim();
    }
}