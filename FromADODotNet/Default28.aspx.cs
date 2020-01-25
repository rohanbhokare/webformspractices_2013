using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default28 : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlDataAdapter da = null;
    DataSet ds = null;
    string commandText = string.Empty;

    int EmpCount;
    decimal EmpSalary;
    decimal EmpSalaryGT;
    int EmpCountGT;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindDataList();
        }
    }
    void BindDataList()
    {
        commandText = "select * from dept";
        da = new SqlDataAdapter(commandText, cn);
        ds = new DataSet();
        da.Fill(ds);
        DataListOuter.DataSource = ds.Tables[0];
        DataListOuter.DataBind();
    }
    protected void DataListOuter_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            Label lblstatus = (Label)e.Item.FindControl("lblStatus");
            Label lblDeptId = (Label)e.Item.FindControl("lblDeptId");
            DataList DataListInner = (DataList)e.Item.FindControl("DataListInner");
            commandText = "select e.EmpId, e.EmpName, e.EmpJob,e.EmpSalary,d.DeptName from Emp e, Dept d where e.DId = d.DeptId and e.DId=" + lblDeptId.Text;
            da = new SqlDataAdapter(commandText, cn);
            ds = new DataSet();
            da.Fill(ds, "emp");
            if (ds.Tables["emp"].Rows.Count > 0)
            {
                DataListInner.DataSource = ds.Tables["emp"];
                DataListInner.DataBind();
            }
            else
            {
                lblstatus.Text = "No Data Found";
            }
        }
        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblEmpCountGT = (Label)e.Item.FindControl("lblEmpCountGT");
            Label lblTotalSalaryGT = (Label)e.Item.FindControl("lblTotalSalaryGT");
            lblEmpCountGT.Text = EmpCount.ToString();
            lblTotalSalaryGT.Text = EmpSalary.ToString();
        }
        EmpSalary = 0;
        EmpCount = 0;
    }

    protected void DataListInner_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblEmpSalary = (Label)e.Item.FindControl("lblEmpSalary");
            if (lblEmpSalary != null)
            {
                EmpSalary = EmpSalary + decimal.Parse(lblEmpSalary.Text);
                EmpCount += 1;
                EmpSalaryGT += decimal.Parse(lblEmpSalary.Text);
                EmpCountGT += 1;
            }
        }
        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblEmpCount = (Label)e.Item.FindControl("lblEmpCount");
            Label lblTotalSalary = (Label)e.Item.FindControl("lblTotalSalary");
            lblEmpCount.Text = EmpCount.ToString();
            lblTotalSalary.Text = EmpSalary.ToString();
        }
       
    }
}