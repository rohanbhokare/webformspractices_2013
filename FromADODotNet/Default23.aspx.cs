using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default23RepeaterAssignment : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlDataAdapter da = null;
    DataSet ds = null;

    string strSqlCommand = string.Empty;

    int _totalemp;
    int _totalLemp;
    int _GTemp;

    decimal _totalSal;
    decimal _totalLSal;
    decimal _GTSal;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["asigStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindLocation();
        }
    }
    void BindLocation()
    {
        strSqlCommand = "Select * from Location";
        da = new SqlDataAdapter(strSqlCommand, cn);
        ds = new DataSet();
        da.Fill(ds,"Loc");
        if (ds.Tables[0].Rows.Count > 0)
        {
            RepeaterLocation.DataSource = ds.Tables["Loc"];
            RepeaterLocation.DataBind();
        }
    }

    protected void RepeaterLocation_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

            Label lblLoactionId = (Label)e.Item.FindControl("lblLocationId");
            Repeater RepeterDept = (Repeater)e.Item.FindControl("RepeaterDept");
            strSqlCommand = "select * from dept where LocationId = " + lblLoactionId.Text;
            da = new SqlDataAdapter(strSqlCommand, cn);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                RepeterDept.DataSource = ds.Tables[0];
                RepeterDept.DataBind();
            }
            else
            {
                Label lblDeptStatus = (Label)e.Item.FindControl("lblDeptStatus");
                lblDeptStatus.Text = "No Depertment Avalible at this Location";
            }
        }
        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblGTEmployee = (Label)e.Item.FindControl("lblGTEmployee");
            Label lblGTSalary = (Label)e.Item.FindControl("lblGTSalary");
            lblGTEmployee.Text = _GTemp.ToString();
            lblGTSalary.Text = _GTSal.ToString();
        }
    }


    protected void RepeaterDept_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblDept = (Label)e.Item.FindControl("lblDeptId");
            Repeater RepeaterEmp = (Repeater)e.Item.FindControl("RepeaterEmp");
            strSqlCommand = "select e.EmpId, e.EmpName, e.EmpJob, e.EmpSalary, d.DeptName from Emp e , dept d where e.DeptId=d.DeptId and e.DeptId=" + lblDept.Text;
            da = new SqlDataAdapter(strSqlCommand, cn);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                RepeaterEmp.DataSource = ds.Tables[0];
                RepeaterEmp.DataBind();
            }
            else
            {
                Label lblEmpStatus = (Label)e.Item.FindControl("lblEmpStatus");
                lblEmpStatus.Text = "<b style='color:red'>No Employee Avalible</b>";
            }
        }
        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblDeptEmpCount = (Label)e.Item.FindControl("lblDeptEmpCount");
            Label lblDeptEmpTotalSalary = (Label)e.Item.FindControl("lblDeptEmpTotalSalary");
            lblDeptEmpCount.Text = _totalLemp.ToString();
            lblDeptEmpTotalSalary.Text = _totalLSal.ToString();
            _totalLSal = _totalLemp = 0;

        }
    }
    protected void RepeaterEmp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblSalary = (Label)e.Item.FindControl("lblSalary");
            _totalSal = _totalSal + decimal.Parse(lblSalary.Text);
            _totalLSal = _totalLSal + decimal.Parse(lblSalary.Text);
            _GTSal = _GTSal + decimal.Parse(lblSalary.Text);
            _totalemp += 1;
            _totalLemp += 1;
            _GTemp += 1;
        }
        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblEmpCount = (Label)e.Item.FindControl("lblEmpCount");
            Label lblEmpTotalSalary = (Label)e.Item.FindControl("lblEmpTotalSalary");
            lblEmpCount.Text = _totalemp.ToString();
            lblEmpTotalSalary.Text = _totalSal.ToString();
            _totalemp = 0;
            _totalSal = 0;
        }
    }
}