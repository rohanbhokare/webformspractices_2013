using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default32 : System.Web.UI.Page
{
    SqlConnection cn =null;
    SqlCommand cmd = null;
    SqlDataAdapter da = null;
    DataSet ds = null;
    string commandText = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            ViewState["SortOn"] = "EmpId";
            ViewState["SortBy"] = "Asc";

            BindEmpData();
        }
    }
    void BindEmpData()
    {
        commandText = "select * from emp Order By " + ViewState["SortOn"].ToString()+" "+ ViewState["SortBy"].ToString() ;
        da = new SqlDataAdapter(commandText,cn);
        ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindEmpData();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //string EmpId = e.Keys["EmpId"].ToString();
        //string EmpId = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string EmpId = GridView1.Rows[e.RowIndex].Cells[1].Text;

        commandText = "delete emp where empid="+EmpId;
        cmd = new SqlCommand(commandText, cn);
        cn.Open();
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("Deleted Successfully");
            BindEmpData();
        }
        else
        {
            Response.Write("Deletion Failed");
        }
        cn.Close();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //// 
        string EmpId = GridView1.Rows[e.RowIndex].Cells[1].Text;
        string EmpName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim();
        string EmpJob = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.Trim();
        string EmpSalary = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text.Trim();
        string DeptId = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text.Trim();

        //else
        //string EmpId = GridView1.DataKeys[e.RowIndex].Value.ToString();
        

        //else

        //string EmpId = e.Keys["EmpId"].ToString();
       
        commandText = "update emp set EmpName='" + EmpName + "', EmpJob='" + EmpJob + "', EmpSalary=" + EmpSalary + ", DId=" + DeptId + " where EmpId=" + EmpId;
        cmd = new SqlCommand(commandText, cn);
        cn.Open();
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("Updated successfully");
            GridView1.EditIndex = -1;
            BindEmpData();
        }
        else
        {
            Response.Write("Updation Failed");
        }
        cn.Close();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindEmpData();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindEmpData();
    }
    protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
    {
        ViewState["SortOn"] = e.SortExpression;
        if (ViewState["SortBy"].ToString() == "Asc")
            ViewState["SortBy"] = "Desc";
        else
            ViewState["SortBy"] = "Asc";
        BindEmpData();
    }
}