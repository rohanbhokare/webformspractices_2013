using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default69 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string str = args.Value;
        args.IsValid = false;
        if (str.Length < 6 || str.Length > 16)
            return;

        // checking atlest for single capital letter
        bool capital = false;
        foreach (char ch in str)
        {
            if (ch >= 'A' && ch <= 'Z')
            {
                capital = true;
                break;
            }
        }
        if (capital == false)
        {
            return;
        }
        // checking atlest for single small letter
        bool small = false;
        foreach (char ch in str)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                small = true;
                break;
            }
        }
        if (!small)
        {
            return;
        }

        bool digit = false;
        foreach (char ch in str)
        {
            if (ch >= '1' && ch <= '9')
            {
                digit = true;
                break;
            }
        }
        if (!digit)
        {
            return;
        }
        args.IsValid = true;
    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        if(CustomValidator1.IsValid)
            Response.Write("Its Validated Sussefully");
    }
}