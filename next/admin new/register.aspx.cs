using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using fee;

using System.Net.Mail;
using System.IO;


public partial class next_admin_new_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        success.Visible = false;
        if (Convert.ToInt32(DropDownList3.SelectedItem.Value) == 2 || Convert.ToInt32(DropDownList3.SelectedItem.Value) == 3)
        {
            rollno.ReadOnly = false;
            Sem.Enabled = true;
            parent.ReadOnly = false;
            parentcontact.ReadOnly = false;
            parentemail.ReadOnly = false;
        }

        else
        {
            rollno.ReadOnly = true;
            Sem.Enabled = false;
            parent.ReadOnly = true;
            parentcontact.ReadOnly = true;
            parentemail.ReadOnly = true;
        }
    }

    public static string CreateRandomPassword()
    {
        int PasswordLength = 8;
        string _allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
        Random randNum = new Random();
        char[] chars = new char[PasswordLength];
        int allowedCharCount = _allowedChars.Length;
        for (int i = 0; i < PasswordLength; i++)
        {
            chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
        }
        return new string(chars);
    }

    public void msgtoparent()
    {
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("kanhaiyapatial@gmail.com");
        msg.To.Add(parentemail.Text);
        msg.Body = "Your Child"+firstname.Text+" "+lastname.Text+" has Registered to our site <br/> Now you can Watch the fee status and other Details of the you Child's Detail's."+ " <br/> Your Login Details are:" +"  <br/> Username : "+parentemail.Text+"<br/> Password :"+CreateRandomPassword();
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

    public void msgtostudent()
    {
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("kanhaiyapatial@gmail.com");
        msg.To.Add(emailaddress.Text);
        msg.Body = "You have successfully Created Account on Fees System <br/> Now You can Check Your Fee Details<br/> Your Name:"+firstname.Text+" "+lastname.Text+"<br/> Your Login Credentials are <br/> Username :"+rollno.Text+"<br/>Password :"+Password.Text ;
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


    public void msgtocc()
    {
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("kanhaiyapatial@gmail.com");
        msg.To.Add(emailaddress.Text);
        msg.Body = "You have successfully Created Account on Fees System <br/> Now You can Check Fee Details of Your Students<br/> Your Name:" + firstname.Text + " " + lastname.Text + "<br/> Your Login Credentials are <br/> Username :" + emailaddress.Text + "<br/>Password :" + Password.Text;
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
    protected void Button1_Click(object sender, EventArgs e)
    {

        clsregister obj = new clsregister();
        clsregistrationprp objprp = new clsregistrationprp();
        objprp.email = emailaddress.Text;
        objprp.f_name = firstname.Text;
        objprp.l_name = lastname.Text;
        objprp.rollno = rollno.Text;
        objprp.sem = Sem.SelectedItem.Text;
        objprp.dept = DropDownList4.SelectedItem.Text;
        objprp.acc_type = DropDownList3.SelectedItem.Text;
        objprp.password = Password.Text;
        objprp.contact = contact.Text;
        objprp.parent = parent.Text;
        objprp.parentemail = parentemail.Text;
        objprp.parentcontact = parentcontact.Text;
        objprp.parentpassword= CreateRandomPassword();
        objprp.lastupd = Convert.ToString(Session["cod"]) + "||" + "Admin" + "||" + Convert.ToString(DateTime.Now);
        //now to send mail

        //try statemnt
        try
        {
            success.Visible = true;
            obj.save_rec_admin(objprp);
            objprp.studentid = obj.findid(objprp);
            obj.join_family(objprp);
            success.Text = "Student " + firstname.Text + "-" + lastname.Text + " Added Successfully";

            if (Convert.ToInt32(DropDownList3.SelectedItem.Value) == 2 || Convert.ToInt32(DropDownList3.SelectedItem.Value) == 3)
            {
                msgtoparent();
                msgtostudent();
            }
            else
            {
                msgtocc();
            }
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
        Sem.Items.Clear();
        DropDownList3.Items.Clear();
        DropDownList4.Items.Clear();
        SetFocus(firstname);


    }
}