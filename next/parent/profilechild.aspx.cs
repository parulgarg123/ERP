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
        if (Page.IsPostBack == false)
        {
            clsregister obj = new clsregister();
            List<clsregistrationprp> k = obj.find_rec(Convert.ToInt32 (Session["stu"]));
            if (k.Count > 0)
            {
                ViewState["regid"] = k[0].regid;
                firstname.Text = k[0].f_name;
                lastname.Text = k[0].l_name;
                email.Text = k[0].email;
                dob.Text = k[0].dob;
                contact.Text = k[0].contact;
                department.Text = k[0].dept;
                fathername.Text = k[0].father;
                mothername.Text = k[0].mother;
                address.Text = k[0].address;
               
                lastupdate.Text = k[0].lastupd;
                //Button1.Text = "update";
            }
        }
    }
}