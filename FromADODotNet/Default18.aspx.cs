using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Default18 : System.Web.UI.Page
{
    SqlConnection connection = null;
    SqlDataAdapter dataAdapter = null;
    DataSet dataSet = null;

    string strSqlCommand = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindData();
        }
    }
    void BindData()
    {
        strSqlCommand = "select e.EmpId,e.EmpName,e.EmpJob,e.EmpSalary,d.DeptName from emp e,Dept d where e.DId = d.DeptId";
        dataAdapter = new SqlDataAdapter(strSqlCommand, connection);
        dataSet = new DataSet();
        dataAdapter.Fill(dataSet, "Emp");
        Repeater.DataSource = dataSet;
        Repeater.DataBind();
    }
}