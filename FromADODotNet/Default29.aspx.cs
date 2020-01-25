using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default29 : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlDataAdapter da = null;
    SqlCommand cmd = null;
    DataSet ds = null;

    string commandText = string.Empty;
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
        commandText = "select e.EmpId, e.EmpName, e.EmpJob, e.EmpSalary, e.DId, d.DeptName from emp e, dept d where e.Did=d.deptId";
        da = new SqlDataAdapter(commandText, cn);
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
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string EmpId = e.CommandArgument.ToString();
        commandText = "delete from emp where EmpId=" + EmpId;
        cmd = new SqlCommand(commandText, cn);

        cn.Open();
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("Record Deleted");
            BindEmpData();
        }
        else
        {
            Response.Write("Deletion Failed");
        }
        cn.Close();
    }
    protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        string EmpId = e.CommandArgument.ToString();
        string EmpName = ((TextBox)e.Item.FindControl("txtEmpName")).Text.Trim();
        string EmpJob = ((TextBox)e.Item.FindControl("txtEmpJob")).Text.Trim();
        string EmpSalary = ((TextBox)e.Item.FindControl("txtEmpSalary")).Text.Trim();
        string DeptId = ((DropDownList)e.Item.FindControl("ddlDept")).SelectedItem.Value;

        commandText = "update emp set EmpName='"+EmpName+"', EmpJob='"+EmpJob+"', EmpSalary="+EmpSalary+", DId="+DeptId+" where EmpId="+EmpId;
        cmd = new SqlCommand(commandText, cn);
        cn.Open();
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("Record Updated Succesfully");
            DataList1.EditItemIndex = -1;
            BindEmpData();
        }
        else
        {
            Response.Write("Record Updated Successfully");
        }
        cn.Close();
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
            commandText = "select * from Dept";
            da = new SqlDataAdapter(commandText, cn);
            ds = new DataSet();
            da.Fill(ds);
            ddlDept.DataSource = ds.Tables[0];
            ddlDept.DataTextField = "DeptName";
            ddlDept.DataValueField = "DeptId";
            ddlDept.DataBind();

            Label lblDeptId = (Label)e.Item.FindControl("lblDeptId");
            ddlDept.SelectedIndex = ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(lblDeptId.Text));
        }
    }
}