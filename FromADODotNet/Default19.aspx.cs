using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Default19 : System.Web.UI.Page
{
    SqlConnection connection;
    SqlCommand command;
    SqlDataAdapter dataAdapter;
    DataSet dataset;
    String strSqlCommand;
    protected void Page_Load(object sender, EventArgs e)
    {
        connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        if (!Page.IsPostBack)
        {
            BindCommentsData();
        }
    }
    void BindCommentsData()
    {
        strSqlCommand = "Select * from Comment order by PostedDate desc";
        dataAdapter = new SqlDataAdapter(strSqlCommand, connection);
        dataset = new DataSet();
        dataAdapter.Fill(dataset);
        Repeter1.DataSource = dataset.Tables[0];
        Repeter1.DataBind();

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        strSqlCommand = "Insert into Comment (UserName,Subject,Comment,PostedDate) Values(@UserName,@Subject,@Comment,@PostedDate)";

        if (connection.State != ConnectionState.Open) 
            connection.Open();
        command = new SqlCommand(strSqlCommand, connection); 
        command.Parameters.AddWithValue("@UserName", txtName.Text);
        command.Parameters.AddWithValue("@Subject", txtSubject.Text); 
        command.Parameters.AddWithValue("@Comment", txtComment.Text); 
        command.Parameters.AddWithValue("@PostedDate", DateTime.Now);

         if (command.ExecuteNonQuery() > 0)         
         {             
             BindCommentsData();
            //Clear Input Fields
             txtName.Text = string.Empty;
             txtSubject.Text = string.Empty;
             txtComment.Text = string.Empty;
         }         
         else         
         {             
             Response.Write("Comment Posting Failed!!!");         
         }         
        connection.Close();
    }
}