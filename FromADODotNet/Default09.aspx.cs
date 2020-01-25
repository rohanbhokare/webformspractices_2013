using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default9 : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlCommand cmd = null;
    SqlDataReader dr = null;

    string strSqlCommand;

    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindEmpData();
            BindDeptData();
        }
    }

    void BindEmpData()
    {
        strSqlCommand="SP_GetAllEmp";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        dr = cmd.ExecuteReader();

        ddlEmpId.DataSource = dr;
        ddlEmpId.DataTextField = "EmpID";
        ddlEmpId.DataValueField = "EmpId";
        ddlEmpId.DataBind();
        ddlEmpId.Items.Insert(0, new ListItem("Select","0"));


        dr.Close();
        cn.Close();
    }

    void BindDeptData()
    {
        strSqlCommand = "SP_GetAllDept";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        dr = cmd.ExecuteReader();
        ddlDept.DataSource = dr;
        ddlDept.DataTextField = "DeptName";
        ddlDept.DataValueField = "DeptId";
        ddlDept.DataBind();
        ddlDept.Items.Insert(0, new ListItem("Select","0"));
        dr.Close();
        cn.Close();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        strSqlCommand="Sp_UpdateEmp";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] p = new SqlParameter[5];
        p[0] = new SqlParameter("@EmpId", ddlEmpId.SelectedValue);
        p[1] = new SqlParameter("@EmpName",txtEmpName.Text);
        p[2] = new SqlParameter("@EmpJob",txtEmpJob.Text);
        p[3] = new SqlParameter("@EmpSalary",txtEmpSal.Text);
        p[4] = new SqlParameter("@DeptId",ddlDept.SelectedValue);
        cmd.Parameters.AddRange(p);
        int rowAffacted = cmd.ExecuteNonQuery();
        if (rowAffacted > 0)
        {
            lblstatus.Text = "Employee Details Updated Successfully";

        }
        else
        {
            lblstatus.Text = "Employe Detail Updation Failed";
        }


    }
    protected void ddlEmpId_SelectedIndexChanged(object sender, EventArgs e)
    {
        strSqlCommand = "SP_GetEmpDetailsByEmpId";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter("@EmpId", ddlEmpId.SelectedValue);
        cmd.Parameters.Add(p);

        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            if (dr.Read())
            {
                txtEmpName.Text = dr["EmpName"].ToString();
                txtEmpJob.Text = dr["EmpJob"].ToString();
                txtEmpSal.Text = dr["EmpSalary"].ToString();
                ddlDept.SelectedIndex = ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(dr["DId"].ToString()));
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }
        dr.Close();
        cn.Close();

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        strSqlCommand = "SP_DeleteEmpDetailsByEmpId";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@EmpId",ddlEmpId.SelectedValue));
        int rowAffected = cmd.ExecuteNonQuery();
        if (rowAffected > 0)
        {
            lblstatus.Text = "successfully";
            BindEmpData();
        }
        else
        {
            lblstatus.Text = "failed";
        }
    }
}