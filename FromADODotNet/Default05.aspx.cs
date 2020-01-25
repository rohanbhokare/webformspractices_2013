//using System;
////using System.Collections.Generic;
////using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default5 : System.Web.UI.Page
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
            Response.Write(ds.Tables[0].Columns[0].ColumnName + " | " + ds.Tables[0].Columns[1].ColumnName + " <hr/> ");
                foreach (DataRow drdept in ds.Tables[0].Rows)
                {
                    Response.Write(drdept[0].ToString() + " | " + drdept[1].ToString() + "<hr/><hr/>");
                    if (drdept.GetChildRows(relation).Length > 0)
                    {
                        Response.Write(ds.Tables[1].Columns[0].ColumnName + " | " + ds.Tables[1].Columns[1].ColumnName + " | " + ds.Tables[1].Columns[2].ColumnName + " | " + ds.Tables[1].Columns[3].ColumnName + " | " + ds.Tables[1].Columns[4].ColumnName + "<hr/>");
                        foreach (DataRow dremp in drdept.GetChildRows(relation))
                        {
                            Response.Write(dremp[0].ToString() + " | " + dremp[1].ToString() + " | " + dremp[2].ToString() + " | " + dremp[3].ToString() + " | " + dremp[4].ToString() + "<hr/>");
                        }
                    }
                    else
                    {
                        Response.Write("<b style='color:red ;border:2px solid red'> No Data Avalible</b><br/>");
                    }
                }
        }
        else
        {
            Response.Write("<b style='color:red;border:2px solid red;color:red' NO dept Data Avalible>/b>");
        }

    }
}