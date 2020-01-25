//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public partial class Default6 : System.Web.UI.Page
{
    SqlConnection con = null;
    SqlCommand cmd = null;
    SqlDataReader dr = null;
    string strSqlCommand = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        if (!IsPostBack)
        {
            BindDeptDDL();
        }
    }

    private void BindDeptDDL()
    {
        strSqlCommand = "select * from dept";
        if (con.State != ConnectionState.Open)
            con.Open();
        cmd = new SqlCommand(strSqlCommand, con);
        dr = cmd.ExecuteReader();
        ddlEmpDept.DataSource = dr;
        ddlEmpDept.DataTextField = "deptname";
        ddlEmpDept.DataValueField = "deptID";
        ddlEmpDept.DataBind();

        ddlEmpDept.Items.Insert(0,new ListItem("select","0"));

        dr.Close();
        con.Close();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        strSqlCommand = "insert into emp(empname,empjob,empsalary,did) values('"+txtEmpName.Text.Trim()+"','"+txtEmpJob.Text.Trim()+"',"+txtEmpSal.Text.Trim()+","+ddlEmpDept.SelectedItem.Value+")";
        if (con.State != ConnectionState.Open)
            con.Open();
        cmd = new SqlCommand(strSqlCommand, con);
        int rowAffected = cmd.ExecuteNonQuery();
        if (rowAffected > 0)
        {
            lblStatus.Text = "<b style='color:green'> Record inserted sucessfully</b>";

            //clear all input Data

            txtEmpName.Text = string.Empty;
            txtEmpJob.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            ddlEmpDept.SelectedIndex = 0;
        }
        else
        {
            lblStatus.Text = "<b style = 'color:red'> Insertion Failed</b>";
        }
        con.Close();
    }
}