using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default15 : System.Web.UI.Page
{
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
            BindDeptData();
        }
        strSqlCommand = "select * from emp";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "EmpData");
    }

    void BindEmpData()
    {
        strSqlCommand = "Select EmpId from emp";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "Emp");
        ddlEmpId.DataSource = ds;
        ddlEmpId.DataTextField = "EmpId";
        ddlEmpId.DataValueField = "EmpId";
        ddlEmpId.DataBind();
        ddlEmpId.Items.Insert(0, new ListItem("Select", "0"));
    }

    void BindDeptData()
    {
        strSqlCommand = "Select * from dept";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "Dept");
        ddlDept.DataSource = ds;
        ddlDept.DataTextField = "DeptName";
        ddlDept.DataValueField = "DeptId";
        ddlDept.DataBind();
        ddlDept.Items.Insert(0, new ListItem("Select", "0"));
    }
    protected void ddlEmpId_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlEmpId.SelectedIndex != 0)
        {
            DataRow[] dr = ds.Tables["EmpData"].Select("EmpId = " + ddlEmpId.SelectedItem.Value);
            txtEmpName.Text = dr[0]["EmpName"].ToString();
            txtEmpJob.Text = dr[0]["EmpJob"].ToString();
            txtEmpSal.Text = dr[0]["EmpSalary"].ToString();
            ddlDept.SelectedIndex = ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(dr[0]["DId"].ToString()));
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        else
        {
            lblstatus.Text = "Please Select the Employee Data";
            txtEmpName.Text = string.Empty;
            txtEmpJob.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            ddlDept.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DataRow[] dr = ds.Tables["EmpData"].Select("EmpId = " + ddlEmpId.SelectedItem.Value);
        dr[0]["EmpName"] = txtEmpName.Text;
        dr[0]["EmpJob"] = txtEmpJob.Text;
        dr[0]["EmpSalary"] = txtEmpSal.Text;
        dr[0]["DId"] = ddlDept.SelectedItem.Value;
        da.UpdateCommand = new SqlCommand();
        da.UpdateCommand.CommandText = "update emp set EmpName=@EmpName, EmpJob=@EmpJob, EmpSalary = @EmpSalary, DId = @DeptId where EmpId=@EmpId";
        da.UpdateCommand.Connection = cn;
        da.UpdateCommand.Parameters.Add("@EmpName", SqlDbType.VarChar, 50, "EmpName");
        da.UpdateCommand.Parameters.Add("@EmpJob", SqlDbType.VarChar, 50, "EmpJob");
        SqlParameter pEmpSalary =  da.UpdateCommand.Parameters.Add("@EmpSalary", SqlDbType.Money);
        pEmpSalary.SourceColumn = "EmpSalary";
        SqlParameter pEmpId = da.UpdateCommand.Parameters.Add("@EmpId", SqlDbType.Int);
        pEmpId.SourceColumn = "EmpId";
        SqlParameter pDeptId = da.UpdateCommand.Parameters.Add("@DeptId", SqlDbType.Int);
        pDeptId.SourceColumn = "DId";
        int rowAffected = da.Update(ds, "EmpData");
        if (rowAffected > 0)
        {
            lblstatus.Text = "Record Updated Successfully";
        }
        else
        {
            lblstatus.Text = "Record Updation Failed";
        }
    
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        strSqlCommand = "Delete From emp where EmpId=@EmpId";
        da.DeleteCommand = new SqlCommand(strSqlCommand,cn);
        SqlParameter pEmpId = da.DeleteCommand.Parameters.Add("@EMpId", SqlDbType.Int);
        pEmpId.SourceColumn = "EmpId";

        DataRow[] dr = ds.Tables["EmpData"].Select("EmpID = "+ ddlEmpId.SelectedItem.Value);
        dr[0].Delete();
        int rowAffected = da.Update(ds,"EmpData");
        if (rowAffected > 0)
        {
            BindEmpData();
            lblstatus.Text = "Record Deleted Successfully";
            txtEmpName.Text = string.Empty;
            txtEmpJob.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            ddlDept.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        else
        {
            lblstatus.Text = "Record Deletion Failed";
        }
    }
}