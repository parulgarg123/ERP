using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using fee;

public partial class next_principal_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        success.Visible = false;
        fname.Focus();
        if (Page.IsPostBack == false)
        {
            clsregister obj = new clsregister();
            List<clsregistrationprp> k = obj.find_rec(Convert.ToInt32(Session["cod"]));
            if (k.Count > 0)
            {
                ViewState["regid"] = k[0].regid;
                fname.Text = k[0].f_name;
                lname.Text = k[0].l_name;
                email.Text = k[0].email;
                dob.Text = k[0].dob;
                contact.Text = k[0].contact;
                //department.Text = k[0].dept;
                father.Text = k[0].father;
                mother.Text = k[0].mother;
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
        objprp.f_name = fname.Text;
        objprp.l_name = lname.Text;
        objprp.email = email.Text;
        objprp.dob = dob.Text;
        objprp.rollno = "NA";
        objprp.sem = "NA";
        objprp.hostel = "NA";
        objprp.bus = "NA";
        objprp.acc_type = "Principle";
        objprp.contact = contact.Text;
        objprp.father = father.Text;
        objprp.dept = "NA";
        objprp.mother = mother.Text;
        objprp.address = address.Text;
        objprp.password = password.Text;
        objprp.lastupd = Convert.ToString("Principle " + Session["name_principle"]) + " " + Convert.ToString(DateTime.Now);
        obj.update_rec(objprp);
        success.Visible = true;
        Response.Redirect("profilepr.aspx");
        success.Text = "   Changes have been updated.";
    }
}