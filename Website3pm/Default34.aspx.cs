using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default34 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     //   lbl1.Text="selected option is <br/> Text : " + ddl1.SelectedItem.Text+ "<br/> Value : " + ddl1.SelectedValue.ToString();
        ddl2.SelectedIndexChanged +=new EventHandler(ddl2_SelectedIndexChanged);
    }
    protected void ddl2_SelectedIndexChanged(object Sender, EventArgs e)
    {
        if (ddl2.SelectedIndex > 0)
            lbl2.Text = "selected option is <br/> Text : " + ddl2.SelectedItem.Text + "<br/> Value : " + ddl2.SelectedValue.ToString();
        else
            lbl2.Text = "select Some Value";
    }
}