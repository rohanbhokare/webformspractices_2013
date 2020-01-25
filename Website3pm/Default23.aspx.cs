using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            CheckBox2.Checked = true;
    }
    protected void Button1_Click(Object sender, EventArgs e)
    {
        Label1.Text="CheckBox1 Option is : " + CheckBox1.Checked.ToString();
        Label1.Text += "</br> CheckBox2 option is : " + CheckBox2.Checked.ToString();

    }
}