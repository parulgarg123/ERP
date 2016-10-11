using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TextBox1.Enabled = false;
        TextBox1.ReadOnly = true;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //TextBox1.Attributes.Add("readonly","false");

        // TextBox1.Enabled = true;
        TextBox1.ReadOnly = false;
    }
}