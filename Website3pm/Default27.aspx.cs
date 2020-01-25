using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default27 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (Control c in Panel1.Controls)
        {
            if (c is CheckBox)
            {
                ((CheckBox)(c)).Attributes.Add("onclick", "validate(this)");
            }

        }
    }
}