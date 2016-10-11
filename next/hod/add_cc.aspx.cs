using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using fee;
using System.Net.Mail;


public partial class next_hod_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        success.Visible = false;
        department.Items.Add(new ListItem(Convert.ToString(Session["dept_hod"]), Convert.ToString(Session["dept_hod"])));
    }

    public void msgtocc()
    {
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("kanhaiyapatial@gmail.com");
        msg.To.Add(email.Text);
        msg.Body = "You have successfully Created Account on Fees System <br/> Now You can Check Fee Details of Your Students<br/> Your Name:" + fname.Text + " " + lname.Text + "<br/> Your Login Credentials are <br/> Username :" + email.Text + "<br/>Password :" + password.Text;
        msg.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
        NetworkCred.UserName = "himalyatest@gmail.com";
        NetworkCred.Password = "123@45678";
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = NetworkCred;
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.Send(msg);
    }
    protected void submit_Click(object sender, EventArgs e)
    {

        clsregister obj = new clsregister();
        clsregistrationprp objprp = new clsregistrationprp();
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
            obj.save_rec(objprp);
            success.Text = "    Class Counsellor " + fname.Text + " " + lname.Text + " Added Successfully";
            msgtocc();
          button_clear();
        }
        catch (Exception exp)
        {
            success.Visible = true;

            success.Text = "ERROR!!!";
        }
    }

    private void button_clear()
    {
        email.Text = string.Empty;
        fname.Text = string.Empty;
        lname.Text = string.Empty;
        department.Text = string.Empty;
        dob.Text = string.Empty;
        father.Text = string.Empty;
        mother.Text = string.Empty;
        address.Text = string.Empty;
        acc_type.Text = string.Empty;
        contact.Text = string.Empty;
        fname.Focus();
    }
}