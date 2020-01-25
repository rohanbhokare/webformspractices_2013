using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataBoundControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            DropDownList1.Items.Insert(0, new ListItem("select", "0"));

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 1)
        {
            lblContent.Text = "<b>Repeater Control</b><br/> <a href='Default19.aspx'>Example1(Comments)</a><br/><a href='Default20.aspx'>Example2</a> <br/><a href='Default22.aspx'>Example3</a>";
            lblContent.Text += "<br/> <a href='Default23.aspx'>Repeater Assignmetn(Location)</a>";
        }
        if (DropDownList1.SelectedIndex == 2)
        {
            lblContent.Text = "<b>DataList Control</b><br/> <a href='Default24.aspx'>Example1(Binding Data to DataList Control)</a><br/>";
            lblContent.Text += "<a href='Default25.aspx'>Example2((C)RUD operations)</a><br/>";
            lblContent.Text += "<a href='Default26.aspx'>Example3 Adding And Viewing Products</a><br/>";
            lblContent.Text += "<a href='Default28.aspx'>Example4 Nesting Of DataList</a><br/>";
            lblContent.Text += "<a href='Default29.aspx'>Assignment on DataList  </a><br/>";
        }
        if (DropDownList1.SelectedIndex == 3)
        {
            lblContent.Text = "<b>GridView</b><br/><a href='Default30.aspx'> Example1 (AutoGenerateColumn)</a> <br/>";
            lblContent.Text += "<a href='Default31.aspx'> Example2(Column Generated using BoundField)</a> <br/>";
            lblContent.Text += "<a href='Default32.aspx'> Example3(Column as BoundField & vommand field perform sortig paging editing deleting)</a> <br/>";

        }
    }
}