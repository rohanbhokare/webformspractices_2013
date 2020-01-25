using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default6IAssig : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        SqlDataAdapter dadept = new SqlDataAdapter("select * from dept", con);
        SqlDataAdapter daemp = new SqlDataAdapter("select * from emp", con);
        DataSet ds = new DataSet();
        dadept.Fill(ds,"ndept");
        daemp.Fill(ds,"nemp");
        DataRelation relation = ds.Relations.Add(ds.Tables["ndept"].Columns["deptid"], ds.Tables[1].Columns[4]);

        if (ds.Tables[0].Rows.Count > 0)
        {
            Response.Write("<table width=100%>");
            Response.Write("<tr><th  width=2%>" + ds.Tables[0].Columns[0].ColumnName + "</th><th align=left> " + ds.Tables[0].Columns[1].ColumnName + " </th></tr> ");
                foreach (DataRow drdept in ds.Tables[0].Rows)
                {
                    Response.Write("<tr><td>" + drdept[0].ToString() + "</td><td> " + drdept[1].ToString() + "</td></tr>");
                    if (drdept.GetChildRows(relation).Length > 0)
                    {
                        int sal = 0;
                        Response.Write("<tr><td colspan='2'><table id='child' width=50%>");
                        Response.Write("<tr><th>" + ds.Tables[1].Columns[0].ColumnName + "</th><th>" + ds.Tables[1].Columns[1].ColumnName + " </th><th> " + ds.Tables[1].Columns[2].ColumnName + "</th><th>" + ds.Tables[1].Columns[3].ColumnName + "</th><th>" + ds.Tables[1].Columns[4].ColumnName + "</th></tr>");
                        foreach (DataRow dremp in drdept.GetChildRows(relation))
                        {
                            Response.Write("<tr><td>" + dremp[0].ToString() + "</td><td>" + dremp[1].ToString() + "</td><td>" + dremp[2].ToString() + "</td><td>" + dremp[3].ToString() + "</td><td>" + dremp[4].ToString() + "</td><tr>");
                            try
                            {
                                sal += Convert.ToInt32(dremp[3]);
                            }
                            catch (FormatException)
                            {
                            }
                        }
                        Response.Write("<tr><td colspan=5>No. of Emp :  "+ drdept.GetChildRows(relation).Length.ToString()+"&nbsp &nbsp");
                        Response.Write("Total salary :  "+sal.ToString());
                        Response.Write("</td></tr></table></td></tr>");
                    }
                    else
                    {
                        Response.Write("<tr><td colspan='2'><b style='color:red ;border:2px solid red'> No Data Avalible</b></td></tr>");
                    }
                }
            int ts = 0;
            foreach(DataRow dr in ds.Tables[1].Rows)
            {
                ts += Convert.ToInt32( dr[3]);
            }

            Response.Write("<tr></tr><tr></tr><tr><th colspan=2>Total Employes: " + ds.Tables[1].Rows.Count.ToString() + "&nbsp &nbsp ");
                Response.Write("Total Salary: " + ts.ToString());
                Response.Write("</th></tr></table>");


        }
        else
        {
            Response.Write("<b style='color:red;border:2px solid red;color:red' NO dept Data Avalible>/b>");
        }
    }
}