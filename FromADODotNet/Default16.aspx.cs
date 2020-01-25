using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default16 : System.Web.UI.Page
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
            BindDeptDdl();
        }
        ds = new DataSet();
        strSqlCommand="SP_GetAllEmp";
        da = new SqlDataAdapter(strSqlCommand,cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds,"Emp");

    }

    void BindDeptDdl()
    {
        strSqlCommand="SP_GetAllDept";
        da = new SqlDataAdapter(strSqlCommand,cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        ds = new DataSet();
        da.Fill(ds, "Dept");
        ddlEmpDept.DataSource = ds.Tables["Dept"];
        ddlEmpDept.DataTextField = "DeptName";
        ddlEmpDept.DataValueField = "DeptId";
        ddlEmpDept.DataBind();
        ddlEmpDept.Items.Insert(0, new ListItem("Select", "0"));
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        strSqlCommand = "SP_InsertEmpDetails";
        da.InsertCommand = new SqlCommand(strSqlCommand, cn);
        da.InsertCommand.CommandType = CommandType.StoredProcedure;
        da.InsertCommand.Parameters.Add("@EmpName", SqlDbType.VarChar, 50, "EmpName");
        da.InsertCommand.Parameters.Add("@EmpJob", SqlDbType.VarChar, 50, "EmpJob");
        SqlParameter pEmpSalary = da.InsertCommand.Parameters.Add("@EmpSalary", SqlDbType.Money);
        pEmpSalary.SourceColumn = "EmpSalary";
        SqlParameter pDeptId = da.InsertCommand.Parameters.Add("@DeptId", SqlDbType.Int);
        pDeptId.SourceColumn = "DId";

        DataRow dr = ds.Tables["Emp"].NewRow();
        dr["EmpName"] = txtEmpName.Text.Trim();
        dr["EmpJob"] = txtEmpJob.Text.Trim();
        dr["EmpSalary"] = txtEmpSal.Text.Trim();
        dr["DId"] = ddlEmpDept.SelectedItem.Value;

        ds.Tables["Emp"].Rows.Add(dr);

        if (da.Update(ds.Tables["Emp"]) > 0)
        {
            lblStatus.Text = "New Employee Inserted Sussefully!!!";
            txtEmpJob.Text = txtEmpName.Text = txtEmpSal.Text = string.Empty;
            ddlEmpDept.SelectedIndex = 0;
        }
        else
        {
            lblStatus.Text = "New Employee Insertion Failed!!!";
        }
    }
}