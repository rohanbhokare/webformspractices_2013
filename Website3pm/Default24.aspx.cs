using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default24 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Checkbox1.CheckedChanged += Checkbox1_CheckedChanged;
    }

    void Checkbox1_CheckedChanged(object sender, EventArgs e)
    {
        Label1.Text = Checkbox1.Checked.ToString();
    }
}