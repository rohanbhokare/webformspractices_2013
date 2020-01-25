using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default8 : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;
    SqlDataReader dr;
   string strSqlCommand;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if(!Page.IsPostBack)
            bindDeptData();
    }

    private void bindDeptData()
    {
        strSqlCommand="SP_GetAllDept";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        dr = cmd.ExecuteReader();

        ddlEmpDept.DataSource = dr;
        ddlEmpDept.DataTextField = "DeptName";
        ddlEmpDept.DataValueField = "deptId";
        ddlEmpDept.DataBind();
        ddlEmpDept.Items.Insert(0, new ListItem("Select", "0"));

        dr.Close();
        cn.Close();
        
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        strSqlCommand = "SP_InsertEmpDetails";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(strSqlCommand, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] p = new SqlParameter[4];

        p[0] = new SqlParameter("@EmpName", txtEmpName.Text.Trim());
        p[1] = new SqlParameter("@EmpJob", txtEmpJob.Text.Trim());
        p[2] = new SqlParameter("@EmpSalary", txtEmpSal.Text.Trim());
        p[3] = new SqlParameter("@DeptId", ddlEmpDept.SelectedItem.Value);
        
        cmd.Parameters.AddRange(p);
        
        int rowAffacted = cmd.ExecuteNonQuery();
        

        if (rowAffacted > 0)
        {
            lblStatus.Text = "Employee Details inserted Successfully !!!";
            txtEmpName.Text = string.Empty;
            txtEmpJob.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            ddlEmpDept.SelectedIndex = 0;
            txtEmpName.Focus();
        }
        else
        {
            lblStatus.Text = "Employee Details insertion Failed !!!";
        }
        //dr.Close();
        cn.Close();
    }
}