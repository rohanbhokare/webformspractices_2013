#region Importing Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
#endregion

public partial class Default10 : System.Web.UI.Page
{
    #region DataMembers
    SqlConnection connection;
    SqlDataAdapter dataAdapter;
    DataSet dataSet;

    string strSqlStatement;
    int pointer;
    int totalRecords;
    #endregion

    
    protected void Page_Load(object sender, EventArgs e)
    {
        connection = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);

        if (!IsPostBack)
        {
            BindEmployeeData();
        }
    }

    #region Binding and displaying data

    private void BindEmployeeData()
    {
        strSqlStatement = "select e.EmpId,e.EmpName,e.EmpJob,e.EmpSalary,d.DeptName from emp e, dept d where e.Did = d.deptid";
        dataAdapter = new SqlDataAdapter(strSqlStatement, connection);
        dataSet = new DataSet();
        dataAdapter.Fill(dataSet, "Employee");
        ViewState["dataset"] = dataSet;
        ViewState["pointer"] = 0;
        DisplayRecord();
    }

    private void DisplayRecord()
    {
        dataSet = (DataSet)ViewState["dataset"];
        pointer = (int)ViewState["pointer"];
        totalRecords = dataSet.Tables["Employee"].Rows.Count;

        DataRow dataRow = dataSet.Tables["Employee"].Rows[pointer];
        lblEmpId.Text = dataRow["EmpId"].ToString();
        lblEmpName.Text = dataRow["EmpName"].ToString();
        lblEmpJob.Text = dataRow["EmpJob"].ToString();
        lblEmpSalary.Text = dataRow["EmpSalary"].ToString();
        lblDeptName.Text = dataRow["DeptName"].ToString();
        lblStatus.Text = "Record "+(pointer+1)+" of " +totalRecords;
        ButtonsEnabling();
     }
    #endregion

    // This function contain Conditions for making button in Enable or disable state according to conditions
    #region Buttons Enabling
    private void ButtonsEnabling()
    {
        if (pointer != 0 && pointer != totalRecords - 1)
        {
            btnPrevious.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;
            btnNext.Enabled = true;
        }
        else
        {
            if (pointer == totalRecords - 1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnPrevious.Enabled = true;
                btnFirst.Enabled = true;
            }
            if (pointer == 0)
            {
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }
        }
        
    }
    #endregion
    
    #region All Buttons' OnClick Methods
    protected void btnFirst_Click(object sender, EventArgs e)
    {
        ViewState["pointer"] = 0;
        DisplayRecord();
    }
    protected void btnLast_Click(object sender, EventArgs e)
    {
        dataSet = (DataSet)ViewState["dataset"];
        ViewState["pointer"] = dataSet.Tables["employee"].Rows.Count - 1;
        DisplayRecord();
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        pointer = (int)ViewState["pointer"]+1;
        ViewState["pointer"] = pointer;
        DisplayRecord();
    }
    protected void btnPrevious_Click(object sender, EventArgs e)
    {
        pointer = (int)ViewState["pointer"] - 1;
        ViewState["pointer"] = pointer;
        DisplayRecord();
    }
    #endregion
}