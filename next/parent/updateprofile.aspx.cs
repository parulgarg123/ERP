using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using fee;

public partial class next_parent_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        success.Visible = false;
        nsuccess.Visible = false;

        fname.Focus();
        if (Page.IsPostBack == false)
        {
            clsregister obj = new clsregister();
            List<clsregistrationprp> k = obj.find_rec_parent(Convert.ToInt32(Session["cod"]));
            if (k.Count > 0)
            {
                ViewState["regid"] = k[0].regid;
                fname.Text = k[0].f_name;
                email.Text = k[0].email;
                contact.Text = k[0].contact;
                address.Text = k[0].address;
                password.Text = k[0].password;
                lastupd.Text = k[0].lastupd;
            }
        }

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        clsregister obj = new clsregister();
        clsregistrationprp objprp = new clsregistrationprp();
        objprp.regid = Convert.ToInt32(Session["cod"]);
        objprp.email = email.Text;
        objprp.f_name = fname.Text;
        objprp.address = address.Text;
        objprp.password = password.Text;
        objprp.contact = contact.Text;
        objprp.lastupd = Convert.ToString("Parent" + Session["Cod"]) + " "+ Convert.ToString(DateTime.Now);
        try
        {
            success.Visible = true;
            obj.update_rec_parent(objprp);
            Response.Redirect("detailpa.aspx");
            success.Text = "Parent" + fname.Text + "-" + " Added Successfully";
        }
        catch (Exception exp)
        {
            nsuccess.Visible = true;
            nsuccess.Text = "ERROR!!!";
        }
    }
}