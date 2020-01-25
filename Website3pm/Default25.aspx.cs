using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default25 : System.Web.UI.Page
{
    protected override void OnInit(EventArgs e)
    {
        this.Load += new EventHandler(Page_Load);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            CheckBox1.Text = "Hide Image";
            Image1.Visible = true;
        }
        else
        {
            CheckBox1.Text = "Show Image";
            Image1.Visible = false;
        }
    }

}