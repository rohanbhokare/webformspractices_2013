using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from emp";
        cmd.Connection = cn;
        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        
        if (dr.HasRows)
        {
            Response.Write("<table> <tr> <th>" + dr.GetName(0) + " </th><th> " + dr.GetName(1) + " </th><th> " + dr.GetName(2) + " </th><th> " + dr.GetName(3) + " </th><th> " + dr.GetName(4) + "</th></tr>");
            while (dr.Read())
            {
                Response.Write("<tr><td>" + dr.GetInt32(0) + " </td><td> " + dr.GetString(1) + " </td><td> " + dr.GetString(2) + " </td><td> " + dr.GetDecimal(3) + " </td><td> " + dr.GetInt32(4) + "</td></tr>");
            }
            Response.Write("</table>");
        }
        else
        {
            Response.Write("no recorde found");
        }
        dr.Close();
        cn.Close();
        
    }
}