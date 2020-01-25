using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default26 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string selectedoption = string.Empty;
        foreach (Control c in form1.Controls)
        {
            if (c is CheckBox)
            {
                CheckBox cb = c as CheckBox;
                if (cb.Checked)
                {
                    selectedoption += cb.Text + ", ";
                }
            }
        }
            if (selectedoption != string.Empty)
            {
                selectedoption = selectedoption.Remove(selectedoption.Length - 2) + ".";
                int pos = selectedoption.LastIndexOf(",");
                if (pos != -1)
                {
                    selectedoption = selectedoption.Insert(pos + 1, " &");
                    selectedoption = selectedoption.Remove(pos, 1);
                }
                lbl.Text = "Selection options are : " + selectedoption;
            }
            else
            {
                lbl.Text = "Nothing is Selected";
            }
    }
}