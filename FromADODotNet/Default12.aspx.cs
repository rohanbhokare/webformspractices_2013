using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Default12 : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlDataAdapter da = null;
    DataSet ds = null;
    SqlCommandBuilder cmdbldr;

    string strSqlCommand = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);

        if (!Page.IsPostBack)
            BindDeptData();
        //insert employee Data in dataset
        strSqlCommand = "Select * from emp";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "emp");

        cmdbldr = new SqlCommandBuilder(da);
    }

    void BindDeptData()
    {
        strSqlCommand = "select * from Dept";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds,"dept");
        ddlEmpDept.DataSource = ds;
        ddlEmpDept.DataTextField = "DeptName";
        ddlEmpDept.DataValueField = "DeptId";
        ddlEmpDept.DataBind();
        ddlEmpDept.Items.Insert(0,new ListItem("Select","0"));
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        DataRow dr = ds.Tables["emp"].NewRow();
        dr["EmpName"] = txtEmpName.Text;
        dr["EmpJob"] = txtEmpJob.Text;
        dr["EmpSalary"] = txtEmpSal.Text;
        dr["DId"] = ddlEmpDept.SelectedValue;
        ds.Tables["emp"].Rows.Add(dr);

        int rowAffacted = da.Update(ds, "emp");
        if (rowAffacted > 0)
        {
            lblStatus.Text = "Record Inserted Successfully !!!";
        }
        else
        {
            lblStatus.Text = "Record Insertion Failed !!!";
        }
    }
}