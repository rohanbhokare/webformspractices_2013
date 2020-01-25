using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default31 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void rdb1_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton rdb = sender as RadioButton;
        if (rdb.ID == "rdb1")
        {
            Panel1.Visible = rdb1.Checked;
            Panel2.Visible = !rdb1.Checked;
        }
        else if(rdb.ID == "rdb2")
        {
            Panel1.Visible = !rdb2.Checked;
            Panel2.Visible = rdb2.Checked;
        }
        
    }
    
    
}