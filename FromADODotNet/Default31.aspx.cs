using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default31 : System.Web.UI.Page
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
            BindData();
        }
    }
    public void BindData()
    {
        strSqlCommand = "select emp.empid, emp.empname, emp.empJob, emp.empsalary, dept.deptName from emp,dept where emp.did=dept.deptid";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}