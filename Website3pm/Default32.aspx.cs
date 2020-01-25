using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default32 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (Control ctrl in form1.Controls)
        {
            if (ctrl is RadioButton)
            {
                RadioButton rdb = (RadioButton)ctrl;
                if (rdb.Checked)
                {
                    Label1.Text = "you have selected : " + rdb.Text;
                    break;
                }
            }

        }
    }
}