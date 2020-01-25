using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default21 : System.Web.UI.Page
{
    SqlConnection cn;
    SqlDataAdapter da;
    DataSet ds;
    string strSqlCommand;
    int empid;

    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindDept();
            BindEmpDetails();
        }
        empid = Convert.ToInt32(Request.QueryString["EmpId"]);

    }

    void BindDept()
    {
        strSqlCommand = "Select * from dept";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds, "dept");
        ddlDept.DataSource = ds.Tables["dept"];
        ddlDept.DataTextField = "DeptName";
        ddlDept.DataValueField = "DeptId";
        ddlDept.DataBind();
    }

    void BindEmpDetails()
    {
        empid = Convert.ToInt32(Request.QueryString["EmpId"]);
        strSqlCommand = "Select * from emp where EmpId=@empid";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        SqlCommand cmd = new SqlCommand(strSqlCommand, cn);
        cmd.Parameters.AddWithValue("empid", empid);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            txtName.Text = dr["EmpName"].ToString();
            txtEmpJob.Text = dr["EmpJob"].ToString();
            txtEmpSalary.Text = dr["EmpSalary"].ToString();
            ddlDept.SelectedIndex = (ddlDept.Items.IndexOf(ddlDept.Items.FindByValue(dr["DId"].ToString())));
        }
        else
        {
            lblStatus.Text = ""+empid;
        }
        dr.Close();
        cn.Close();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        strSqlCommand = "update emp set EmpName='"+ txtName.Text +"', EmpJob='"+txtEmpJob.Text+"', EmpSalary = "+txtEmpSalary.Text+",DId = "+int.Parse(ddlDept.SelectedItem.Value)+" where Empid = "+empid;
        if (cn.State != ConnectionState.Open)
            cn.Open();
        SqlCommand cmd = new SqlCommand(strSqlCommand, cn);
        if (cmd.ExecuteNonQuery() > 0)
        {
            lblStatus.Text = "Record Updated";
        }
        else
        {
            lblStatus.Text = "Failed";
        }
        cn.Close();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default20.aspx");
    }
}