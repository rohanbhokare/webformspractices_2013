using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select deptid,deptname from dept;select empid,empname,empsalary from emp";
        cmd.Connection = con;

        SqlDataReader dr = cmd.ExecuteReader();
        while(dr.HasRows)
        {
            Response.Write(dr.GetName(0) + " | " + dr.GetName(1) + " <hr/> ");
            while (dr.Read()) 
                Response.Write(dr.GetInt32(0)+" | "+ dr.GetString(1)+" <hr/> ");
            dr.NextResult();
        }
        dr.Close();
        con.Close();
    }
}