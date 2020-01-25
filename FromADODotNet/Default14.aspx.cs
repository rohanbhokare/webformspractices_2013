using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default14 : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlDataAdapter da = null;
    DataSet ds = new DataSet();

    string strSqlCommand = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindDeptData();
        }
        
    }

    void BindDeptData()
    {
        strSqlCommand = "select * from dept";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "Emp");
        ddlEmpDept.DataSource = ds;
        ddlEmpDept.DataTextField = "DeptName";
        ddlEmpDept.DataValueField = "DeptID";
        ddlEmpDept.DataBind();
        ddlEmpDept.Items.Insert(0, new ListItem("Select", "0"));

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        strSqlCommand = "select * from Emp";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "EmpData");

        DataRow dr = ds.Tables["EmpData"].NewRow();
        dr["EmpName"] = txtEmpName.Text;
        dr["EmpJob"] = txtEmpJob.Text;
        dr["EmpSalary"] = txtEmpSal.Text;
        dr["DId"] = ddlEmpDept.SelectedItem.Value;

        ds.Tables["EmpData"].Rows.Add(dr);

        strSqlCommand = "insert into emp (EmpName,EmpJob,EmpSalary,DId)values(@EmpName,@EmpJob,@EmpSalary,@DId)";
        da.InsertCommand = new SqlCommand(strSqlCommand, cn);
        da.InsertCommand.Parameters.Add("@EmpName", SqlDbType.VarChar, 50,"EmpName");
        da.InsertCommand.Parameters.Add("@EmpJob",SqlDbType.VarChar,50,"EmpJob");
        SqlParameter pEmpSalary = da.InsertCommand.Parameters.Add("@EmpSalary", SqlDbType.Money);
        pEmpSalary.SourceColumn = "EmpSalary";
        SqlParameter pEmpId = da.InsertCommand.Parameters.Add("@DId",SqlDbType.Int);
        pEmpId.SourceColumn = "DId";
        int rowAff = da.Update(ds, "EmpData");
        if (rowAff > 0)
        {
            lblStatus.Text = "Employee Data Inserted Successfully";
        }
        else
        {
            lblStatus.Text = "Employee Data Insertion Failed";
        }
    }
}