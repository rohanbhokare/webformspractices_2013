using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default11 : System.Web.UI.Page
{
    SqlConnection cn;
    SqlDataAdapter da = null;
    DataSet ds = new DataSet();
    string strSqlCommand = string.Empty;

    int rp = 0;
    
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
        strSqlCommand = "select e.EmpId,e.EmpName,e.EmpJob,e.EmpSalary,d.DeptName from emp e,dept d where e.DId=d.DeptId";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();

        da.Fill(ds, "EmpData");
        ViewState["ds"] = ds;
        ViewState["rp"] = 0;
        ShowData();    
    }
    void ShowData()
    {
        ds = (DataSet)ViewState["ds"];
        rp = (int)ViewState["rp"];
        DataTable dt = ds.Tables["EmpData"];
        DataRowCollection drc = dt.Rows;
        DataRow dr = drc[rp];
    //DataRow drc = ds.Tables["EmpData"].Rows[rp];
        lblEmpId.Text = dr["EmpId"].ToString();
        lblEmpName.Text = dr["EmpName"].ToString();
        lblEmpJob.Text = dr["EmpJob"].ToString();
        lblEmpSalary.Text = dr["EmpSalary"].ToString();
        lblDeptName.Text = dr["DeptName"].ToString(); 
    }
    protected void btnFirst_Click(object sender, EventArgs e)
    {
        ViewState["rp"] = 0;
        ShowData();
    }
    protected void btnPrevious_Click(object sender, EventArgs e)
    {
        rp = (int)ViewState["rp"];
        ds = (DataSet)ViewState["ds"];
        if (rp >0)
        {
            rp = rp - 1;
            ViewState["rp"] = rp;
            ShowData();
        }
        else
        {
            lblStatus.Text = "This is the First Record";
        } 
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        rp = (int)ViewState["rp"];
        ds = (DataSet)ViewState["ds"];
        if (rp < ds.Tables["EmpData"].Rows.Count - 1)
        {
            rp = rp + 1;
            ViewState["rp"] = rp;
            ShowData();
        }
        else
        {
            lblStatus.Text = "This is the Last Record";
        }
    }
    protected void btnLast_Click(object sender, EventArgs e)
    {
        ds = (DataSet)ViewState["ds"];
        ViewState["rp"] = ds.Tables["EmpData"].Rows.Count - 1;
        ShowData();
    }
}