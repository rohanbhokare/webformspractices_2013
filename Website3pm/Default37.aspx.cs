using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Default37 : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            try
            {
                string FileName = Path.GetExtension(FileUpload1.PostedFile.FileName);
               
                string ServerFolder = Server.MapPath("Uploaded\\");
                lblresult.Text += FileName + ", " ;
                //if (!Directory.Exists(ServerFolder))
                //{
                //    Directory.CreateDirectory(ServerFolder);
                //}
                //string serverfilepath = ServerFolder + FileName;
                //FileUpload1.SaveAs(serverfilepath);
                //lblresult.Text = "<p style='color:green'> File Uploaded Sussefully !!! </p>";
            }
            catch (Exception ex)
            {
                lblresult.Text = "<p style='color:red'>" + ex.Message +"</p>";
            }
        }
        else
        {
            lblresult.Text = "<p style='color:red'> Plz Upload file </p>"; 

        }
    }
}