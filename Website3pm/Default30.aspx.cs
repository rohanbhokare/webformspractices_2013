﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button1_Click(object sender, EventArgs e)
    {
        lbl.Text = "option1 is " + rdb1.Checked.ToString();
        lbl.Text += "<br/> option2 is " + rdb2.Checked.ToString(); 
    }
}