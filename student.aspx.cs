using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using fee;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (Page.IsPostBack == false)
        {
            if (Request.Cookies["rollno"] != null && Request.Cookies["password"] != null)
            {
                username.Text = Request.Cookies["rollno"].Value;
                password.Attributes["value"] = Request.Cookies["password"].Value;
            }
        }

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        clsregister obj = new clsregister();
        clsregistrationprp objprp = new clsregistrationprp();
        objprp.rollno = username.Text;
        objprp.password = password.Text;
        Label1.Visible = true;
                        
        try
        {
             
        Int32 b = obj.logincheckrollb(objprp);
        Int32 a = obj.logincheckrolla(objprp);

        if (b == -6)
        {
            Session["cod"] = a;
            Response.Redirect("next/student/detailsu.aspx");
        }
        else if (b == -5)
        {
            Session["cod"] = a;
            Response.Redirect("next/parent/detailpa.aspx");
        }
       
        else
        {
            Label1.Text = "error";
        }
    }
        catch(Exception exp)
        {
            Label1.Text = "INVALID USERNAME PASSWORD";
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
