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
public partial class next_student_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            clsregister obj = new clsregister();
            List<clsregistrationprp> k = obj.find_rec(Convert.ToInt32(Session["cod"]));
            if (k.Count > 0)
            {
                ViewState["regid"] = k[0].regid;
                firstname.Text = k[0].f_name;
                lastname.Text = k[0].l_name;
                email.Text = k[0].email;
                dob.Text = k[0].dob;
                rollno.Text = k[0].rollno;
                contact.Text = k[0].contact;
                department.Text = k[0].dept;
                fathername.Text = k[0].father;
                mothername.Text = k[0].mother;
                address.Text = k[0].address;
                password.Text = k[0].password;
                lastupdate.Text = k[0].lastupd;
                //Button1.Text = "update";
            }
        }
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        if (password.Text == cpassword.Text)
        {
            clsregister obj = new clsregister();
            clsregistrationprp objprp = new clsregistrationprp();
            objprp.regid = Convert.ToInt32(Session["cod"]);
            objprp.password = password.Text;
            objprp.lastupd = Convert.ToString(Session["cod"]) + "||" + "Student " + "||" + firstname.Text + "-" + lastname.Text+ Convert.ToString(DateTime.Now);
          
            try
            {
                success.Visible = true;
                obj.change_pass(objprp);
                success.Text = "Password Successfully Changed " ;
            }
            catch (Exception exp)
            {
                success.Visible = true;

                success.Text = exp + "ERROR!!!";
            }
        }
    
    else
    {
            success.Visible = true;
            success.Text = "Password Does Not Match";
        }
    }

    protected void change_Click(object sender, EventArgs e)
    {
        changepassword.Visible = false;
        passwordlbl.Visible = true;
        password.Visible = true;
        cnfrmpasswordlbl.Visible = true;
        cpassword.Visible = true;
        submit.Visible = true;
        cancel.Visible = true;
    }

    protected void cancel_Click(object sender, EventArgs e)
    {
        cancel.Visible = false;
        changepassword.Visible = true;
        passwordlbl.Visible = false;
        password.Visible =false;
        cnfrmpasswordlbl.Visible = false;
        cpassword.Visible = false;
        submit.Visible = false;
        
        

    }
}