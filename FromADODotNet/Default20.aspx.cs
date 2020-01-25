using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default20 : System.Web.UI.Page
{
    SqlConnection cn;

    SqlDataAdapter da;
    DataSet ds;
    string strSqlCommand;


    protected void Page_Load(object sender, EventArgs e)
    {

        
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindEmpRepeter();
        }
        
    }

    void BindEmpRepeter()
    {
        strSqlCommand ="select e.EmpId,e.EmpName,e.EmpJob,e.EmpSalary,e.DId,d.DeptName from emp e, dept d where e.DId = d.DeptId";
        da = new SqlDataAdapter(strSqlCommand,cn);
        ds=new DataSet();
        da.Fill(ds,"Emp");
        Repeter1.DataSource = ds.Tables["Emp"];
        Repeter1.DataBind();
    }

    decimal totalSalary;
    int totalRecords = 0;    

    protected void Repeter1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblTotalSalary = (Label)e.Item.FindControl("lblSalary");
            if (lblTotalSalary != null)
            {
                totalSalary += decimal.Parse(lblTotalSalary.Text);
                totalRecords += 1;
            }
        }
        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblGtotalR = (Label)e.Item.FindControl("lblTotalRecords");
            Label lblGS = (Label)e.Item.FindControl("lblGrandTotalSalary");
            lblGtotalR.Text = totalRecords.ToString();
            lblGS.Text = totalSalary.ToString();
        }
    }
    protected void Repeter1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int empid = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Delete")
        {
            strSqlCommand = "delete from emp where EmpId = " +empid;
            SqlCommand cmd = new SqlCommand(strSqlCommand, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                BindEmpRepeter();
            }
            cn.Close();
        }
        else if (e.CommandName == "Edit")
        {
            Response.Redirect("Default21.aspx?EmpId=" + empid);
        }
    }
}