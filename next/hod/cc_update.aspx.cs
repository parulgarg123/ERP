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
        nsuccess.Visible = false;
        fname.Focus();
        if (Page.IsPostBack == false)
        {
            clsregister obj = new clsregister();
            List<clsregistrationprp> k = obj.find_rec(Convert.ToInt32(Session["regid"]));
            if (k.Count > 0)
            {
                ViewState["regid"] = k[0].regid;
                fname.Text = k[0].f_name;
                lname.Text = k[0].l_name;
                // rollno.Text = k[0].rollno;
                email.Text = k[0].email;
                dob.Text = k[0].dob;
                contact.Text = k[0].contact;
                father.Text = k[0].father;
                mother.Text = k[0].mother;
                address.Text = k[0].address;
                department.Text = k[0].dept;
                // semester.Text = k[0].sem;
                acc_type.Text = k[0].acc_type;
                // hostel.Text = k[0].hostel;
                // bus.Text = k[0].bus;
                lastupd.Text = k[0].lastupd;
                password.Text = k[0].password;
                // lastupd.Text = k[0].lastupd;
            }
        }
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        clsregister obj = new clsregister();
        clsregistrationprp objprp = new clsregistrationprp();
        objprp.regid = Convert.ToInt32(Session["regid"]);
        objprp.email = email.Text;
        objprp.f_name = fname.Text;
        objprp.l_name = lname.Text;
        objprp.rollno = "NA";
        objprp.sem = "NA";
        objprp.dept = department.Text;
        objprp.dob = dob.Text;
        objprp.father = father.Text;
        objprp.mother = mother.Text;
        objprp.hostel = "NA";
        objprp.bus = "NA";
        objprp.address = address.Text;
        objprp.acc_type = acc_type.Text;
        objprp.password = password.Text;
        objprp.contact = contact.Text;
        objprp.lastupd = Convert.ToString("HOD " + Session["name_hod"]) + " " + Session["dept_hod"] + " " + Convert.ToString(DateTime.Now);
        try
        {
            success.Visible = true;
            obj.update_rec(objprp);
            Response.Redirect("view.aspx");
            success.Text = "CC " + fname.Text + "-" + lname.Text + " Added Successfully";
        }
        catch (Exception exp)
        {
            nsuccess.Visible = true;
            nsuccess.Text = "ERROR!!!";
        }
    }
}