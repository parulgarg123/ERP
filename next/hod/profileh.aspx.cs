using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using fee;

public partial class next_hod_Default : System.Web.UI.Page
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
                department.Text = k[0].dept;
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
        objprp.acc_type = "HOD";
        objprp.contact = contact.Text;
        objprp.dept = department.Text;
        objprp.father = father.Text;
        objprp.mother = mother.Text;
        objprp.address = address.Text;
        objprp.password = password.Text;
        objprp.lastupd = Convert.ToString("HOD " + Session["name_hod"]) + " " + Session["dept_hod"] + " " + Convert.ToString(DateTime.Now);
        obj.update_rec(objprp);
        success.Visible = true;
        Response.Redirect("profileh.aspx");
        success.Text = "   Changes have been updated.";
    }
}