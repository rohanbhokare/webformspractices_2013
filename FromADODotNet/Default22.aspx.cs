using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default22 : System.Web.UI.Page
{
    SqlConnection cn;
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    string strSqlCommand;

    int empCount;
    int empGTCount;
    decimal empSalary;
    decimal empGTSalary;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindDept();
        }
    }
    void BindDept()
    {
        strSqlCommand = "Select * from Dept";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds,"Dept");
        RepeaterDept.DataSource = ds.Tables["Dept"];
        RepeaterDept.DataBind();
    }
    protected void RepeaterDept_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblDeptId=(Label)e.Item.FindControl("lblDeptId");
            Repeater RepeaterEmp = (Repeater)e.Item.FindControl("RepeaterEmp");
            strSqlCommand = "select e.EmpId,e.EmpName,e.EmpJob,e.EmpSalary,e.DId, d.DeptName from emp e, dept d where e.DId=d.DeptId and e.DId="+ lblDeptId.Text;
            da = new SqlDataAdapter(strSqlCommand, cn);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                RepeaterEmp.DataSource = ds.Tables[0];
                RepeaterEmp.DataBind();
            }
            else
            {
                Label lblStatus = (Label)e.Item.FindControl("lblStatus");
                lblStatus.Text = "No Employee Data in this Depertment";
            }
        }
        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblGTEmployee=(Label)e.Item.FindControl("lblGTEmployee");
            Label lblGTSalary=(Label)e.Item.FindControl("lblGTSalary");
            lblGTEmployee.Text = empGTCount.ToString();
            lblGTSalary.Text = empGTSalary.ToString();
        }
        empCount = 0;
        empSalary = 0;
    }
    protected void RepeaterEmp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblSalary = (Label)e.Item.FindControl("lblSalary");
            empCount++;
            empGTCount++;
            empSalary += decimal.Parse(lblSalary.Text);
            empGTSalary += decimal.Parse(lblSalary.Text);
        }

        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblEmployee = (Label)e.Item.FindControl("lblTotalEmp");
            Label lblSalary = (Label)e.Item.FindControl("Label1");
            lblEmployee.Text = empCount.ToString();
            lblSalary.Text = empSalary.ToString();
        }
     
    }
}