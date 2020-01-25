using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Default38 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string serverFolder = Server.MapPath("FilesUploaded\\");
        if(!Directory.Exists(serverFolder))
            Directory.CreateDirectory(serverFolder);
        lblResult1.Text = string.Empty;
        lblResult2.Text = string.Empty;
        string lblText1 = "<table  style='color:green' align ='center'> <tr> <th>  File Name </th><th> || File Type </th><th> || File Size </th></tr>";
        string lblText2 = "<table  style='color:red' align='center'> <tr> <th> File Name </th><th>|| File Type </th><th>|| File Size </th></tr>";
        if (FileUpload1.HasFiles)
        {

            try
            {
                foreach (HttpPostedFile hpf in FileUpload1.PostedFiles)
                {
                    string FileName = Path.GetFileName(hpf.FileName);
                    string type = Path.GetExtension(hpf.FileName);
                    int size = hpf.ContentLength;
                    if (hpf.ContentType == "application/pdf" ||
                        hpf.ContentType == "application/msword" ||
                        hpf.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" ||
                        hpf.ContentType == "text/plain")
                    {
                        if(size <= 1048576)
                        {
                            FileUpload1.SaveAs(serverFolder+FileName);
                            lblText1 += "<tr> <td>" + FileName + "</td><td>" + type + "</td><td>" + size / 1024 + " kb </td> </tr>";
                        }
                        else
                        {
                            lblText2 += "<tr> <td>" + FileName + "</td><td>" + type + "</td><td> <b style='color:black'><u>" + size / 1024 + "kb </u></b></td> </tr>";
                        }
                    }
                    else
                    {
                        lblText2 += "<tr> <td>" + FileName + "</td><td><b style='color:black'><u>" + type + "</u></b></td><td>" + size / 1024 + " kb </td> </tr>";

                    }
                }
                    
                //for (int i = 0; i < FileUpload1.PostedFiles.Count; i++)
                //{
                //    string FN = Path.GetFileName(FileUpload1.PostedFiles[i].FileName);
                //    string Typ = Path.GetExtension(FileUpload1.PostedFiles[i].FileName);
                //    int size = FileUpload1.PostedFiles[i].ContentLength;
                    
                //    string filetype = FileUpload1.PostedFiles[i].ContentType;
                //    if (filetype == "application/pdf" ||
                //        filetype == "application/msword" ||
                //        filetype == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" ||
                //        filetype == "text/plain")
                //    {
                //        //if (size <= 1048576)
                //        //{
                //        //    FileUpload1.SaveAs(serverFolder + FN);
                //        //    lblText1 += "<tr> <td>" + FN + "</td><td>" + Typ + "</td><td>" + size/1024 + " kb </td> </tr>";
                //        //}
                //        //else
                //        //{
                //        //    lblText2 += "<tr> <td>" + FN + "</td><td>" + Typ + "</td><td>" + size/1024 + "kb </td> </tr>";
                //        //}
                //    }
                //    else
                //    {
                //        lblText2 += "<tr> <td>" + FN + "</td><td>" + Typ + "</td><td>" + size/1024 + " kb </td> </tr>";
                         
                //    }
                    
                //}

                lblResult1.Text = "<b style='color:green'><u>Following files uploaded Sucessfully</u></b> <br/>" +lblText1 + "</table>";
                lblResult2.Text = "<br/> <br/><b style='color:red'><u>Following files Failed to upload </u></b> <br/>" + lblText2 + "</table>";
                
            }
            catch (Exception)
            {
            }
            
        }
        else
        {
            lblResult1.Text = "<b style='color:red'> Please select File for Upload </b>";
        }
    }
}