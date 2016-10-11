using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

public partial class next_parent_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        parent();
        Label3.Text = Convert.ToString(Session["name_parent"]) + "'s Panel";
        if (Session["cod"] == null)
            Response.Redirect("~/parents.aspx");
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/parents.aspx");
    }
    private void parent()
    {
        string abc = null;
        

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mirza"].ConnectionString);
        conn.Open();
        SqlCommand command = new SqlCommand("Select * from [parent] WHERE regid=" + Session["cod"], conn);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                abc = reader[1].ToString();
               
            }
        }
        Session["name_parent"] = abc ;

        conn.Close();
    }

    protected void btnContactUs_Click(object sender, EventArgs e)
    {
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("kanhaiyapatial@gmail.com");
        msg.To.Add(txtemail.Text);
        msg.Body = TextBox2.Text;
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
}
