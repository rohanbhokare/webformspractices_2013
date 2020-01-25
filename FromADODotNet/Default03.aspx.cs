using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        con.Open();
        string StrSqlCommand = "select * from emp";
        SqlDataAdapter da = new SqlDataAdapter();


        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = StrSqlCommand;
        cmd.Connection = con;
        da.SelectCommand = cmd;
        // or
        //da.SelectCommand = new SqlCommand();
        //da.SelectCommand.CommandText = StrSqlCommand;
        //da.SelectCommand.Connection = con;


        DataSet ds = new DataSet();
        da.Fill(ds,"t1emp");
        DataTable dt = ds.Tables["t1emp"];
        DataRowCollection drc = dt.Rows;
        if (drc.Count > 0)
        {
            Response.Write("EMPID | EMPNAME | EMPJOB | EMPSAL | DEPNO <hr/>");
            foreach (DataRow dr in drc)
            {
                Response.Write(dr[0].ToString() + " | " + dr[1].ToString() + " | " + dr[2].ToString() + " | " + dr[3].ToString() + " | " + dr[4].ToString() + " <hr/>");
            }
        }
        else
        {
            Response.Write("no empl");
        }
    }
}