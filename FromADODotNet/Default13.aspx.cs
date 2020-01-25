using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default13 : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlDataAdapter da = null;
    DataSet ds = null;
    string strSqlCommand = string.Empty;
    SqlCommandBuilder bldr;

    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindDeptData();
            BindEmpData();
        }
        strSqlCommand = "Select * from emp";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "EmpData");
        bldr = new SqlCommandBuilder(da);
    }

    void BindEmpData()
    {
        strSqlCommand = "select EmpId from emp";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "Emp");
        ddlEmpId.DataSource = ds;
        ddlEmpId.DataTextField = "EmpId";
        ddlEmpId.DataValueField = "EmpId";
        ddlEmpId.DataBind();
        ddlEmpId.Items.Insert(0,new ListItem("Select","0"));

    }
    void BindDeptData()
    {
        strSqlCommand = "select * from dept";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "Dept");
        ddlDept.DataSource = ds;
        ddlDept.DataTextField = "DeptName";
        ddlDept.DataValueField = "DeptId";
        ddlDept.DataBind();
        ddlDept.Items.Insert(0, new ListItem("Select", "0"));

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DataRow[] dr = ds.Tables["EmpData"].Select("EmpId = " + ddlEmpId.SelectedValue);
        dr[0]["EmpName"] = txtEmpName.Text.Trim();
        dr[0]["EmpJob"] = txtEmpJob.Text.Trim();
        dr[0]["EmpSalary"] = txtEmpSal.Text.Trim();
        dr[0]["DId"] = ddlDept.SelectedValue;

        int rowAffacted = da.Update(ds,"EmpData");
        if (rowAffacted > 0)
        {
            lblstatus.Text = "Record Updated Successfully";
            ddlEmpId.SelectedIndex = 0;
            txtEmpName.Text = string.Empty;
            txtEmpJob.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            ddlDept.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        else
        {
            lblstatus.Text = "Record Updation Failed";
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        DataRow[] dr = ds.Tables["EmpData"].Select("EmpId = " + ddlEmpId.SelectedValue);
        dr[0].Delete();

        if (da.Update(ds,"EmpData") > 0)
        {
            lblstatus.Text = "Record Deleted Successfully";
            ddlEmpId.SelectedIndex = 0;
            txtEmpName.Text = string.Empty;
            txtEmpJob.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            ddlDept.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            BindEmpData();
        }
        else
        {
            lblstatus.Text = "Record Deletion Failed";
        }

    }
    protected void ddlEmpId_SelectedIndexChanged(object sender, EventArgs e)
    {
        strSqlCommand = "select * from emp where EmpId = " + ddlEmpId.SelectedValue;
        da = new SqlDataAdapter(strSqlCommand, cn);
        DataRow[] dr =  ds.Tables["EmpData"].Select("EmpId=" + ddlEmpId.SelectedValue);
        txtEmpName.Text = dr[0]["EmpName"].ToString();
        txtEmpJob.Text = dr[0]["EmpJob"].ToString();
        txtEmpSal.Text = dr[0]["EmpSalary"].ToString();
        ddlDept.SelectedIndex = ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(dr[0]["DId"].ToString()));
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;
    }
}