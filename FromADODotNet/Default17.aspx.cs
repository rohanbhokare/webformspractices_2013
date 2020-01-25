using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Default17 : System.Web.UI.Page
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
            BindEmpDDL();
            BindDeptDDL();
        }
        strSqlCommand = "SP_GetAllEmp";
        da = new SqlDataAdapter(strSqlCommand, cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        ds = new DataSet();
        da.Fill(ds, "EmpData");
    }

    void BindEmpDDL()
    {
        strSqlCommand = "SP_GetAllEmp";
        da = new SqlDataAdapter(strSqlCommand, cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        ds = new DataSet();
        da.Fill(ds, "Emp");
        ddlEmpId.DataSource = ds.Tables["Emp"];
        ddlEmpId.DataTextField="EmpId";
        ddlEmpId.DataValueField="EmpId";
        ddlEmpId.DataBind();
        ddlEmpId.Items.Insert(0, new ListItem("Select","0"));
    }

    void BindDeptDDL()
    {
        strSqlCommand = "SP_GetAllDept";
        da = new SqlDataAdapter(strSqlCommand, cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        ds = new DataSet();
        da.Fill(ds, "Dept");
        ddlDept.DataSource=ds.Tables["Dept"];
        ddlDept.DataTextField ="DeptName";
        ddlDept.DataValueField = "DeptId";
        ddlDept.DataBind();
        ddlDept.Items.Insert(0, new ListItem("Select","0"));
    }
    protected void ddlEmpId_SelectedIndexChanged(object sender, EventArgs e)
    {
        strSqlCommand = "SP_GetEmpDetailsByEmpId";
        da = new SqlDataAdapter(strSqlCommand, cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@EmpId", ddlEmpId.SelectedItem.Value);
        ds = new DataSet();
        da.Fill(ds, "EmpDetail");
        DataRowCollection drc = ds.Tables["EmpDetail"].Rows;
        if (drc.Count > 0)
        {
            DataRow dr = ds.Tables["EmpDetail"].Rows[0];
            txtEmpName.Text = dr["EmpName"].ToString();
            txtEmpJob.Text = dr["EmpJob"].ToString();
            txtEmpSal.Text = dr["EmpSalary"].ToString();
            ddlDept.SelectedIndex = ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(dr["DId"].ToString()));
            btnDelete.Enabled = btnUpdate.Enabled = true;
        }
        else
        {
            lblstatus.Text = "No Rows Avalible in DataBase";
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        strSqlCommand = "Sp_UpdateEmp";
        da.UpdateCommand = new SqlCommand(strSqlCommand, cn);
        da.UpdateCommand.CommandType = CommandType.StoredProcedure;
        SqlParameter pEmpId = da.UpdateCommand.Parameters.Add("@EmpId", SqlDbType.Int);
        pEmpId.SourceColumn = "EmpId";
        SqlParameter pDeptId = da.UpdateCommand.Parameters.Add("@DeptId", SqlDbType.Int);
        pDeptId.SourceColumn = "DId";
        SqlParameter PEmpSalary = da.UpdateCommand.Parameters.Add("@EmpSalary", SqlDbType.Money);
        PEmpSalary.SourceColumn = "EmpSalary";
        da.UpdateCommand.Parameters.Add("@EmpName", SqlDbType.VarChar, 50, "EmpName");
        da.UpdateCommand.Parameters.Add("@EmpJob", SqlDbType.VarChar, 50, "EmpJob");

        DataRow[] dr = ds.Tables["EmpData"].Select("EmpId = " + ddlEmpId.SelectedItem.Value);
        dr[0]["EmpName"] = txtEmpName.Text.Trim();
        dr[0]["EmpJob"] = txtEmpJob.Text.Trim();
        dr[0]["EmpSalary"] = txtEmpSal.Text.Trim();
        dr[0]["DId"] = ddlDept.SelectedItem.Value;
        dr[0]["EmpId"] = ddlEmpId.SelectedItem.Value;

        if (da.Update(ds,"EmpData") > 0)
        {
            lblstatus.Text = " Employee Data Updated Successfully !!!";
        }
        else
        {
            lblstatus.Text = " Employee Data Updation Failed !!!";

        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        strSqlCommand = "SP_DeleteEmpDetailsByEmpId";
        da.DeleteCommand = new SqlCommand(strSqlCommand, cn);
        da.DeleteCommand.CommandType = CommandType.StoredProcedure;
        SqlParameter pEmpId = da.DeleteCommand.Parameters.Add("@EmpId", SqlDbType.Int);
        pEmpId.SourceColumn = "EmpId";
        pEmpId.SourceVersion = DataRowVersion.Original;

        DataRow[] dr = ds.Tables["EmpData"].Select("EmpId =" + ddlEmpId.SelectedItem.Value);
        dr[0].Delete();

        if (da.Update(ds, "EmpData") > 0)
        {
            lblstatus.Text = "Selected Employee Deleated Successfully!!!";
            txtEmpName.Text = txtEmpJob.Text = txtEmpSal.Text = string.Empty;
            ddlEmpId.SelectedIndex = 0;
            ddlDept.SelectedIndex = 0;
            BindEmpDDL();
        }
        else
        {
            lblstatus.Text = "Selected Employee Deletion Failed!!!";
        }
    }
}