using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default25 : System.Web.UI.Page
{
    SqlCommand cmd = null;
    SqlConnection cn = null;
    SqlDataAdapter da = null;
    DataSet ds = null;
    string strSqlCommand = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindEmpData();
        }
    }
    void BindEmpData()
    {
        strSqlCommand = "select e.EmpId, e.EmpName, e.EmpJob, e.EmpSalary, e.DId, d.DeptName from Emp e, Dept d where e.DId=d.DeptId";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds);
        DataList1.DataSource = ds.Tables[0];
        DataList1.DataBind();
    }
    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = e.Item.ItemIndex;
        BindEmpData();
    }
    protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = -1;
        BindEmpData();
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.EditItem)
        {
            DropDownList ddlDept = (DropDownList)e.Item.FindControl("ddlDept");
            strSqlCommand = "Select * from Dept";
            da = new SqlDataAdapter(strSqlCommand, cn);
            ds = new DataSet();
            da.Fill(ds);
            ddlDept.DataSource = ds.Tables[0];
            ddlDept.DataTextField = "DeptName";
            ddlDept.DataValueField = "DeptId";
            ddlDept.DataBind();
            Label lblDeptId =(Label)e.Item.FindControl("lblDeptId");
            ddlDept.SelectedIndex = ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(lblDeptId.Text));
        }
    }
    protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        string strEmpId = ((Label)e.Item.FindControl("lblEmpId")).Text.Trim();
        string strEmpName = ((TextBox)e.Item.FindControl("txtEmpName")).Text.Trim();
        string strEmpJob = ((TextBox)e.Item.FindControl("txtEmpJob")).Text.Trim();
        string strEmpSalary = ((TextBox)e.Item.FindControl("txtEmpSalary")).Text.Trim();
        string strEmpDeptId = ((DropDownList)e.Item.FindControl("ddlDept")).SelectedItem.Value;

        strSqlCommand = "Update emp set EmpName=@EmpName, EmpJob=@EmpJob, EmpSalary=@EmpSalary, DId=@DeptId where EmpId=@EmpId";
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.Parameters.AddWithValue("EmpId", strEmpId);
        cmd.Parameters.AddWithValue("EmpName", strEmpName);
        cmd.Parameters.AddWithValue("EmpJob", strEmpJob);
        cmd.Parameters.AddWithValue("EmpSalary", strEmpSalary);
        cmd.Parameters.AddWithValue("DeptId", strEmpDeptId);
        if (cn.State != ConnectionState.Open)
            cn.Open();
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("Record Updated Successfully");
            DataList1.EditItemIndex = -1;
            BindEmpData();
        }
        else
        {
            Response.Write("Updation Failed");
        }
        cn.Close();
    }
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string strEmpId = e.CommandArgument.ToString();
        strSqlCommand = "delete from emp where EmpId=" + strEmpId;
        cmd = new SqlCommand(strSqlCommand, cn);
        cn.Open();
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("deleated");
            BindEmpData();
        }
        else
        {
            Response.Write("Deletion Failed");
        }
        cn.Close();
    }
}