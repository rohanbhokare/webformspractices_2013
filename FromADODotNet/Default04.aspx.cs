using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = new SqlCommand();
        da.SelectCommand.CommandText = "select * from dept;select * from emp";
        da.SelectCommand.Connection = con;

        DataSet ds = new DataSet();

        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            Response.Write(ds.Tables[0].Columns[0].ColumnName + " | " + ds.Tables[0].Columns[1].ColumnName + "<hr/>");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Response.Write(dr[0].ToString() + " | " + dr[1].ToString() + " <hr/>");
            }
        }
        else
        {
            Response.Write("no data in dept");
        }
        if (ds.Tables[1].Rows.Count > 0)
        {
            Response.Write(ds.Tables[1].Columns[1].ColumnName + " | " + ds.Tables[1].Columns[2].ColumnName + " | " + ds.Tables[1].Columns[2].ColumnName + " | " + ds.Tables[1].Columns[3].ColumnName + " | " + ds.Tables[1].Columns[4].ColumnName + " <hr/><hr/> ");
            foreach (DataRow dr in ds.Tables[1].Rows)
            {
                Response.Write(dr[0].ToString() + " | "+dr[1].ToString() + " | "+dr[2].ToString() + " | "+dr[3].ToString() + " | "+dr[4].ToString() + " <hr/> ");
            }
        }
        else
        {
            Response.Write("no data in emp");
        }
    }
}