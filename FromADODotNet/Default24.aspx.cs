using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Default24 : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlDataAdapter da = null;
    DataSet ds = null;
    string strSqlComand = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindEmpData();
        }
    }
    void BindEmpData()
    {
        strSqlComand = "select e.EmpId,e.EmpName,e.EmpJob,e.EmpSalary,e.DId,d.DeptName from Emp e, dept d where e.DId = d.DeptId";
        da = new SqlDataAdapter(strSqlComand, cn);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataList1.DataSource = ds.Tables[0];
            DataList1.DataBind();
        }
    }
}