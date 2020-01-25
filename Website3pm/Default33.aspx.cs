using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default33 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void rdb_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is RadioButton)
        {
            RadioButton rdb = sender as RadioButton;
            lbl.Text = rdb.Text;            
        }

    }
}