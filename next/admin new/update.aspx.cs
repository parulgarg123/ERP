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
using fee;


public partial class next_admin_new_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

         
        firstname.Focus();
        if (Page.IsPostBack == false)
        {
            string pID = Convert.ToString(Session["regid"]);
          
                clsregister obj = new clsregister();
                List<clsregistrationprp> k = obj.find_rec(Convert.ToInt32(pID));
            List<clsregistrationprp> p = obj.find_parent(Convert.ToInt32(pID));

                if (k.Count > 0)
                {
                    ViewState["regid"] = k[0].regid;
                    firstname.Text = k[0].f_name;
                    lastname.Text = k[0].l_name;
                    rollno.Text = k[0].rollno;
                    emailaddress.Text = k[0].email;
                    dob.Text = k[0].dob;
                    contact.Text = k[0].contact;
                    father_name.Text = k[0].father;
                    mother_name.Text = k[0].mother;
                    address.Text = k[0].address;
                parentcontact.Text = p[0].parentcontact;
                parentemail.Text = p[0].parentemail;
                    DropDownList4.SelectedItem.Text = k[0].dept;
                    Sem.SelectedItem.Text = k[0].sem;
                    DropDownList3.SelectedItem.Text = k[0].acc_type;
                    hostel.Text = k[0].hostel;
                    bus.Text = k[0].bus;
                    Password.Text = k[0].password;
                    lstupd.Text = k[0].lastupd;



                }
           
        }
        if (Convert.ToInt32(DropDownList3.SelectedItem.Value) == 2 || Convert.ToInt32(DropDownList3.SelectedItem.Value) == 3)
        {
            rollno.ReadOnly = false;
            Sem.Enabled = true;
         // parent.ReadOnly = false
            parentcontact.ReadOnly = false;
            parentemail.ReadOnly = false;
        }

        else
        {
            rollno.ReadOnly = true;
            Sem.Enabled = false;
            //parent.ReadOnly = true;
            parentcontact.ReadOnly = true;
            parentemail.ReadOnly = true;
        }
    }
           
        

    
        



    protected void Button1_Click(object sender, EventArgs e)
    {


        {
            clsregister obj = new clsregister();
            clsregistrationprp objprp = new clsregistrationprp();
            objprp.regid = Convert.ToInt32(Session["regid"]);
            objprp.email = emailaddress.Text;
            objprp.father = father_name.Text;
            objprp.f_name = firstname.Text;
            objprp.l_name = lastname.Text;
            objprp.mother = mother_name.Text;
            objprp.dob = dob.Text;
            objprp.bus = bus.Text;
            objprp.hostel = hostel.Text;
            objprp.rollno = rollno.Text;
            objprp.sem = Sem.SelectedItem.Text;
            objprp.address = address.Text;
            objprp.dept = DropDownList4.SelectedItem.Text;
            objprp.acc_type = DropDownList3.SelectedItem.Text;
            objprp.password = Password.Text;
            objprp.parentcontact = parentcontact.Text;
            objprp.parentemail = parentemail.Text;
            objprp.parent = father_name.Text;
            objprp.contact = contact.Text;
            objprp.lastupd = Convert.ToString(Session["cod"]) + "||" + "Admin" + "||" + Convert.ToString(DateTime.Now);
            obj.update_rec(objprp);
            try
            {
                success.Visible = true;
                obj.update_rec(objprp);
                obj.update_parent(objprp);
                success.Text = "Student " + firstname.Text + "-" + lastname.Text + " Added Successfully";
            }
            catch (Exception exp)
            {
                success.Visible = true;

                success.Text = exp + "ERROR!!!";
            }


            firstname.Text = string.Empty;
            lastname.Text = string.Empty;
            rollno.Text = string.Empty;
            emailaddress.Text = string.Empty;
            rollno.Text = string.Empty;
            contact.Text = string.Empty;
            Password.Text = string.Empty;
            father_name.Text = string.Empty;
            mother_name.Text = string.Empty;
            address.Text = string.Empty;
            bus.Text = string.Empty;
            hostel.Text = string.Empty;
            dob.Text = string.Empty;
            DropDownList3.Items.Clear();
            DropDownList4.Items.Clear();



        }
    }
}