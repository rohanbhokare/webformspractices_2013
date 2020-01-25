using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Default15 : System.Web.UI.Page
{
    HtmlInputButton btn1;
    HtmlImage img1;

   

    
    protected void Page_Load(object sender, EventArgs e)
    {
        this.btn1 = new HtmlInputButton();
        this.btn1.Value = "Show Image";
        this.btn1.Attributes["Style"] = "background-color:black; color:white";
        
        this.img1 = new HtmlImage();
        this.img1.Src = "~/Image/img1.jpg";
        this.img1.Visible = false;
        this.img1.Width=500;
        this.img1.Height = 500;

        this.form1.Controls.Add(img1);

        this.form1.Controls.Add(btn1);

        this.btn1.ServerClick += new EventHandler(btn1_Click);
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        if (this.btn1.Value == "Show Image")
        {
            this.btn1.Value = "Hide Image";
            this.img1.Visible = true;
        }
        else
        {
            this.btn1.Value = "Show Image";
            this.img1.Visible = false;
        }
    }
}