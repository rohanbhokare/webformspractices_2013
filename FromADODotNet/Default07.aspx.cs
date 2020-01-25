//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default7 : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlCommand cmd = null;
    SqlDataReader dr = null;
    string strSqlCommand = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
       cn = new SqlConnection();
       cn.ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
       
       if (!IsPostBack)
       {
           bindToDdlDeptName();
           bindToDdlEmpId();

       }
    }
    private void bindToDdlEmpId()
    {
        strSqlCommand = "select empid from emp";

        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        dr = cmd.ExecuteReader();
        ddlEmpId.DataSource = dr;
        ddlEmpId.DataTextField = "empid";
        ddlEmpId.DataValueField = "empid";
        ddlEmpId.DataBind();
        ddlEmpId.Items.Insert(0, new ListItem("select", "0"));
        dr.Close();
        cn.Close();
    }

    private void bindToDdlDeptName()
    {
        strSqlCommand = "select * from dept";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        dr = cmd.ExecuteReader();

        ddlDept.DataSource = dr;
        ddlDept.DataTextField = "deptname";
        ddlDept.DataValueField = "deptid";
        ddlDept.DataBind();
        ddlDept.Items.Insert(0, new ListItem("select", "0"));

        dr.Close();
        cn.Close();
    }




    protected void ddlEmpId_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlEmpId.SelectedIndex > 0)
        {
            strSqlCommand = "select * from emp where empid = " + ddlEmpId.SelectedValue;

            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd = new SqlCommand(strSqlCommand, cn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read()) 
                {
                    txtEmpName.Text = dr["empname"].ToString();
                    txtEmpJob.Text = dr["empjob"].ToString();
                    txtEmpSal.Text = dr["empsalary"].ToString();
                    ddlDept.SelectedIndex = ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(dr["did"].ToString()));
                    ddlDept.SelectedIndex = ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(dr["did"].ToString()));
                }
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                lblstatus.Text = "no data avalible";
            }
            dr.Close();
            cn.Close();
        }
        else
        {
            lblstatus.Text = "please Select some Employe Id";
            txtEmpName.Text = string.Empty;
            txtEmpJob.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            ddlDept.SelectedIndex = 0;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // prepair Sql statement for updating command.
        strSqlCommand = "update emp set empname='" + txtEmpName.Text + "',empjob='" + txtEmpJob.Text + "',empsalary=" + txtEmpSal.Text + ",did=" + ddlDept.SelectedValue + " where empid=" + ddlEmpId.SelectedValue;

        if (cn.State != ConnectionState.Open)
            cn.Open();

        cmd = new SqlCommand(strSqlCommand, cn);
        int recordaffected = cmd.ExecuteNonQuery();

        if (recordaffected > 0)
            lblstatus.Text = "Updated sucessfully";
        else
            lblstatus.Text = "Updation Failed";
        cn.Close();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        strSqlCommand = "delete from emp where empid=" + ddlEmpId.SelectedValue;
        if (cn.State != ConnectionState.Open)
            cn.Open();

        cmd = new SqlCommand(strSqlCommand, cn);
        int rowaffected = cmd.ExecuteNonQuery();
        if (rowaffected > 0)
        {
            lblstatus.Text = "Deleted Sucessfully";
            txtEmpJob.Text = string.Empty;
            txtEmpName.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            ddlDept.SelectedIndex = 0;
            bindToDdlEmpId();
        }

        else
            lblstatus.Text = "Deletion Failed";

    }
}